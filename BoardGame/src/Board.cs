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

        public Cell[,] Grid { get; set; }

        private Label label1 = new Label()
        {
            Text = "Score :",
            Location = new Point(12, 600),
        };
        public Board (int rowSize, int columnSize, MainMenuPage mainMenu)
        {
            RowSize = rowSize;
            ColumnSize = columnSize;

            mainMenu.SetBoardPanelDimensions(rowSize, columnSize, Cell.BUTTON_WIDTH, Cell.BUTTON_HEIGHT);

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

                    mainMenu.AddCellToBoardPanel(Grid[i, j]);
                }
            }
            
            mainMenu.Controls.Add(label1);
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

            while(true)
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
        private bool isGridAvailable(int row, int col)
        {
            if (Grid[col, row].Occupied == false) 
            {
                return true;
            }
            return false;
        }
        public int getScoreCheckbord()
        {
            string text;
            Color color;
            int count = 0;
            int score = 0;
            //check Horz
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 1; j < ColumnSize; j++)
                {
                    if (Grid[j - 1, i].Text == Grid[j, i].Text && Grid[j - 1, i].ForeColor == Grid[j, i].ForeColor && Grid[j, i].Occupied)
                    {
                        count++;
                        if (count == 4)
                        {
                            for (int k = j; k > j - 5; k--)
                            {
                                Grid[k, i].ForeColor = Color.White;
                                Grid[k, i].Text = "";
                                Grid[k, i].Occupied = false;
                            }
                            if (Settings1.Default.easy == true)
                            {
                                score += 1;
                            }
                            if (Settings1.Default.normal == true)
                            {
                                score += 3;
                            }
                            if (Settings1.Default.hard == true)
                            {
                                score += 5;
                            }
                            if (Settings1.Default.custom == true)
                            {
                                score += 2;
                            }
                        }
                    }
                    else { count = 0;  }
                }    
            }
            //check Vert
            for (int i = 0; i < ColumnSize; i++)
            {
                for (int j = 1; j < RowSize; j++)
                {
                    if (Grid[i, j - 1].Text == Grid[i, j].Text && Grid[i, j - 1].ForeColor == Grid[i, j].ForeColor && Grid[i, j].Occupied)
                    {
                        count++;
                        if (count == 4)
                        {
                            for (int k = j; k > j - 5; k--)
                            {
                                Grid[i, k].ForeColor = Color.White;
                                Grid[i, k].Text = "";
                                Grid[i, k].Occupied = false;
                            }
                            if (Settings1.Default.easy == true)
                            {
                                score += 1;
                            }
                            if (Settings1.Default.normal == true)
                            {
                                score += 3;
                            }
                            if (Settings1.Default.hard == true)
                            {
                                score += 5;
                            }
                            if (Settings1.Default.custom == true)
                            {
                                score += 2;
                            }
                        }
                    }
                    else { count = 0;  }
                }
            }
            if(score == 0) { OccupyThreeRandomLocation(); }
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
                DialogResult result = MessageBox.Show(message," ", buttons);
                if (result == DialogResult.OK) 
                {
                    MainMenuPage mainMenuPage = new MainMenuPage();
                    mainMenuPage.ShowDialog();
                }                  
            }
        }
        private List<int> memoryRow = new List<int>();
        private List<int> memoryCol = new List<int>();
        private int[,] ghostGrid = new int[50,50];
        private int tmp;
        private void Move( string shape, Color color)
        {
            Grid[memoryCol[0], memoryRow[0]].Occupied = false;
            Grid[memoryCol[memoryRow.Count() - 1], memoryRow[memoryRow.Count() - 1]].Occupied = true;
            for (int i = 0; i < memoryRow.Count() - 1;i++)
            {
                Grid[memoryCol[i+1], memoryRow[i + 1]].ForeColor = color;
                Grid[memoryCol[i+1], memoryRow[i + 1]].Text = shape;
                Grid[memoryCol[i], memoryRow[i]].ForeColor = Color.White;
                Grid[memoryCol[i], memoryRow[i]].Text = "";
                Task.Delay(500).Wait();
            }
            memoryRow.Clear();
            memoryCol.Clear();
            
            tmp += getScoreCheckbord();
            label1.Text = "Score : "+tmp.ToString();
            gameover();
        }
        
        private void CopyGrid()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    if (Grid[i, j].Occupied)
                    { ghostGrid[i,j] = -1; }
                    else { ghostGrid[i,j] = 0; }
                }
            }
        }
        private void getmove(int row, int col)
        {

            if (isGridAvailable(row, col))
            {
                memoryRow.Add(row);
                memoryCol.Add(col);

                Movement(nextrow, nextcol, row, col, shapemove, colormove);
            }
            
        }
        private void Movement(int nextrow, int nextcol, int currrow, int currcol, string shape, Color color)
        {
            if (currcol == nextcol && currrow == nextrow)
            {
                return;
            }
            else if (currcol == nextcol) //UpDown
            {
                if (currrow > nextrow) // up
                {
                    getmove(currrow - 1, currcol);
                }
                if (currrow < nextrow) // down
                {
                    getmove(currrow + 1, currcol);
                }
            }
            else if (currrow == nextrow) // LeftRight
            {
                if (currcol > nextcol) // left
                {
                    getmove(currrow, currcol - 1);
                }
                if (currcol < nextcol) // right
                {
                    getmove(currrow, currcol + 1);
                }
            }
            else if (currrow != nextrow && currcol != nextcol) //diaganal
            {
                if (currcol > nextcol) // left
                {
                    getmove(currrow, currcol - 1);
                }
                if (currcol < nextcol) // right
                {
                    getmove(currrow, currcol + 1);
                }
            }
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
        private int currrow = 0, currcol = 0, nextrow = 0, nextcol = 0;
        private bool shapeSelected = false;
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

           
            if (EnabledShapes.Contains(button.Text))
            {
                getIndex(button, ref currrow, ref currcol);
                shapemove = button.Text;
                colormove = button.ForeColor;
                shapeSelected = true;
            }
            else if(!EnabledShapes.Contains(button.Text) && shapeSelected == true)
            {
                //get
                CopyGrid();
                
                getIndex(button, ref nextrow, ref nextcol);
                memoryRow.Add(currrow);
                memoryCol.Add(currcol);
                Movement(nextrow, nextcol, currrow, currcol, shapemove, colormove);
                Move(shapemove, colormove);
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
