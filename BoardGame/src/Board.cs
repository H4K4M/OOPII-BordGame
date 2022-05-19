using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame.src.design
{
    public class Board
    {
        public int RowSize { get; set; }
        public int ColumnSize { get; set; }

        private HashSet<Color> EnabledColors = new HashSet<Color>();
        private HashSet<string> EnabledShapes = new HashSet<string>();
        private MainMenuPage mainGame = new MainMenuPage();

        public Cell[,] Grid { get; set; }

        private Label label1 = new Label()
        {
            Text = "Score :",
            Location = new Point(12, 600),
        };
        public Board(int rowSize, int columnSize, MainMenuPage mainMenu)
        {
            RowSize = rowSize;
            ColumnSize = columnSize;
            mainGame = mainMenu;
            mainGame.SetBoardPanelDimensions(rowSize, columnSize, Cell.BUTTON_WIDTH, Cell.BUTTON_HEIGHT);

            Grid = new Cell[RowSize, ColumnSize];

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    Grid[i, j] = new Cell();


                    Grid[i, j].Height = Cell.BUTTON_HEIGHT;
                    Grid[i, j].Width = Cell.BUTTON_WIDTH;

                    Grid[i, j].Click += new EventHandler(Button_Click);

                    Grid[i, j].Location = new Point(i * Cell.BUTTON_HEIGHT, j * Cell.BUTTON_WIDTH);

                    mainGame.AddCellToBoardPanel(Grid[i, j]);
                }
            }

            mainGame.Controls.Add(label1);
            FillColorsAndShapesSetsUsingSettings();
            OccupyThreeRandomLocation();
        }

        public Color GetRandomColorFromSet()
        {
            Random random = new Random();

            int RandomNumber = random.Next(0, EnabledColors.Count);

            return EnabledColors.ElementAt(RandomNumber);
        }

        public string GetRandomShapeFromSet()
        {
            Random random = new Random();

            int RandomNumber = random.Next(0, EnabledShapes.Count);

            return EnabledShapes.ElementAt(RandomNumber);
        }

        public void OccupyThreeRandomLocation()
        {
            int n = 0;
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    if (!Grid[i, j].Occupied)
                    {
                        n++;
                    }
                }
            }
            if (n > 3)
            {
                OccupyRandomLocation();
                OccupyRandomLocation();
                OccupyRandomLocation();
            }
            else if (n == 2)
            {
                OccupyRandomLocation();
                OccupyRandomLocation();
            }
            else
            {
                OccupyRandomLocation();
            }

        }

        public void OccupyRandomLocation()
        {
            Random random = new Random();

            while (true)
            {
                int RowNumber = random.Next(0, RowSize);
                int ColumnNumber = random.Next(0, ColumnSize);

                if (Grid[RowNumber, ColumnNumber].Occupied == false)
                {
                    Color RandomColor = GetRandomColorFromSet();
                    string RandomShape = GetRandomShapeFromSet();

                    Grid[RowNumber, ColumnNumber].ForeColor = RandomColor;
                    Grid[RowNumber, ColumnNumber].Text = RandomShape;

                    Grid[RowNumber, ColumnNumber].Occupied = true;
                    return;
                }
            }
        }

        private void FillColorsAndShapesSetsUsingSettings()
        {
            AddShapeToSetIfChecked(Settings1.Default.square, Shape.Square.Value);

            AddShapeToSetIfChecked(Settings1.Default.triangle, Shape.Triangle.Value);

            AddShapeToSetIfChecked(Settings1.Default.round, Shape.Circle.Value);

            AddColorToSetIfChecked(Settings1.Default.red, Color.Red);

            AddColorToSetIfChecked(Settings1.Default.blue, Color.Blue);

            AddColorToSetIfChecked(Settings1.Default.green, Color.Green);
        }

        private void AddShapeToSetIfChecked(bool Checked, string Shape)
        {
            if (Checked)
            {
                EnabledShapes.Add(Shape);
            }
        }

        private void AddColorToSetIfChecked(bool Checked, Color color)
        {
            if (Checked)
            {
                if (Color.Red.Equals(color))
                {
                    EnabledColors.Add(color);
                }

                if (Color.Green.Equals(color))
                {
                    EnabledColors.Add(color);
                }

                if (Color.Blue.Equals(color))
                {
                    EnabledColors.Add(color);
                }

            }
        }
        public int getscore(int j, int i)
        {
            
            if (Settings1.Default.easy == true)
            {
                return 1;
            }
            if (Settings1.Default.normal == true)
            {
                return 3;
            }
            if (Settings1.Default.hard == true)
            {
                return 5;
            }
            if (Settings1.Default.custom == true)
            {
                return 2;
            }
            return 0;
        }
        public int getScoreCheckbord()
        { 
            int countHorz = 0, countVert = 0;
            int score = 0;
            
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 1; j < ColumnSize; j++)
                {
                    //check Horz
                    if (Grid[j - 1, i].Text == Grid[j, i].Text && Grid[j - 1, i].ForeColor == Grid[j, i].ForeColor && Grid[j, i].Occupied)
                    {
                        countHorz++;
                        if (countHorz == 4)
                        {
                            for (int k = j; k > j - 5; k--)
                            {
                                Grid[k, i].ForeColor = Color.White;
                                Grid[k, i].Text = "";
                                Grid[k, i].Occupied = false;
                            }
                            score += getscore(j, i);
                        }
                    }
                    else { countHorz = 0; }
                    //check Vert
                    if (Grid[i, j - 1].Text == Grid[i, j].Text && Grid[i, j - 1].ForeColor == Grid[i, j].ForeColor && Grid[i, j].Occupied)
                    {
                        countVert++;
                        if (countVert == 4)
                        {
                            for (int k = j; k > j - 5; k--)
                            {
                                Grid[i, k].ForeColor = Color.White;
                                Grid[i, k].Text = "";
                                Grid[i, k].Occupied = false;
                            }
                            score += getscore(j, i);
                        }
                    }
                    else { countVert = 0; }
                }
            }
            if (score == 0) { OccupyThreeRandomLocation(); }
            return score;
        }
        private void gameover()
        {
            int n = 0;
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    if (Grid[i, j].Occupied)
                    { n++; }
                }
            }
            if (n == RowSize * ColumnSize)
            {
                string message = "Game Over\n" + "Total Score: " + tmp.ToString();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, " ", buttons);
                if (result == DialogResult.OK)
                { 
                    mainGame.BoardPanel.Controls.Clear();
                    mainGame.DetermineBoardSize();
                }
            }
        }
        class Index
        {
            public int row;
            public int col;
            public Index prev;
            public Index(int row, int col)
            {
                this.row = row;
                this.col = col;
                prev = null;

            }
        }       
        private void Move(List<Index> list)
        {
            for(int i = list.Count - 1; i > 0; i--)
            {
                Task.Delay(1000).Wait();

                int r = list[i].row;
                int c = list[i].col;

                int nr = list[i - 1].row;
                int nc = list[i - 1].col;
                // destination cell
                Grid[nc, nr].ForeColor = colormove;
                Grid[nc, nr].Text = shapemove;
                Grid[nc, nr].Occupied = true;
                // start cell
                Grid[c, r].ForeColor = Color.White;
                Grid[c, r].Text = "";
                Grid[c, r].Occupied = false;

            }
        }
        private bool shortpath(int srcX, int srcY, int destX, int destY, ref List<Index> list)
        {
            char[,] grid = new char[RowSize, ColumnSize];
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    if (!Grid[j, i].Occupied) //empty
                    {
                        grid[i, j] = '1';
                    }
                    if (Grid[j, i].Occupied) //Occupide
                    {
                        grid[i, j] = '0';
                    }
                    if (i == srcX && j == srcY) { grid[i, j] = 's'; } //start
                    if (i == destX && j == destY) { grid[i, j] = 'd'; } //destination
                }
            }
            Index src = new Index(0, 0);
            bool[,] visited = new bool[RowSize, ColumnSize];
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    if (grid[i, j] == '0')
                        visited[i, j] = true;  //visited
                    else
                        visited[i, j] = false;

                    if (grid[i, j] == 's')
                    {
                        src.row = i;
                        src.col = j;
                    }
                }
            }
            List<Index> indexes = new List<Index>();
            indexes.Add(src);
            visited[src.row, src.col] = true;
            while (indexes.Any())
            {
                Index p = indexes[0];
                indexes.RemoveAt(0);

                if (grid[p.row, p.col] == 'd')
                {
                    while (p != null)
                    {
                        list.Add(p);
                        p = p.prev;
                    }
                    return true;
                }

                // up
                if (p.row - 1 >= 0 && visited[p.row - 1, p.col] == false)
                {
                    Index q = new Index(p.row - 1, p.col);
                    q.prev = p;
                    indexes.Add(q);
                    visited[p.row - 1, p.col] = true;
                }

                // down
                if (p.row + 1 < RowSize && visited[p.row + 1, p.col] == false)
                {
                    Index q = new Index(p.row + 1, p.col);
                    q.prev = p;
                    indexes.Add(q);
                    visited[p.row + 1, p.col] = true;
                }

                // left
                if (p.col - 1 >= 0 && visited[p.row, p.col - 1] == false)
                {
                    Index q = new Index(p.row, p.col - 1);
                    q.prev = p;
                    indexes.Add(q);
                    visited[p.row, p.col - 1] = true;
                }

                // right
                if (p.col + 1 < ColumnSize && visited[p.row, p.col + 1] == false)
                {
                    Index q = new Index(p.row, p.col + 1);
                    q.prev = p;
                    indexes.Add(q);
                    visited[p.row, p.col + 1] = true;
                }
            }
            return false;
        }
        private void getIndex(Button button, ref int row, ref int col)
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    if (Grid[i, j].Location == button.Location)
                    {
                        row = j;
                        col = i;
                        return;
                    }
                }
            }
        }
        private string shapemove;
        private Color colormove;
        private int tmp;
        private int currrow = 0, currcol = 0, nextrow = 0, nextcol = 0;
        private bool shapeSelected = false;
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
       
            if (EnabledShapes.Contains(button.Text)) //first click
            {
                getIndex(button, ref currrow, ref currcol);
                shapemove = button.Text;
                colormove = button.ForeColor;
                shapeSelected = true;
            }
            else if(!EnabledShapes.Contains(button.Text) && shapeSelected == true) //Destination click
            {               
                getIndex(button, ref nextrow, ref nextcol);
                List<Index> list = new List<Index>();
                if(shortpath(currrow,currcol,nextrow,nextcol,ref list)) // check short path
                {
                    Move(list); //make move
                    Task.Delay(1000).Wait();
                    tmp += getScoreCheckbord(); //get score if no score random new 3 shape and color
                    label1.Text = "Score : " + tmp.ToString();
                    gameover();
                }
                else
                {
                    MessageBox.Show("No path to move");
                }
                shapeSelected = false;
            }   
        }
        public Board()
        {
            RowSize = 0;
            ColumnSize = 0;
        }

    }
}
