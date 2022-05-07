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
            OccupyRandomLocation();
            OccupyRandomLocation();
            OccupyRandomLocation();
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

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
        }

        public Board()
        {
            RowSize = 0;
            ColumnSize = 0;
        }
    }
}
