using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Media;

namespace BoardGame.src.design
{
    public partial class MultiplayerGame : Form
    {
        public Cell[,] Grid;
        private Color[] colors = new Color[3]{Color.Red, Color.Green, Color.Blue};
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
        private string IP;
        public MultiplayerGame(bool isHost, string IP = null, int Port = 0)
        {
            InitializeComponent();
            this.IP = IP;
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
            if (isHost) //Host
            {
                getBoard();
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
                Player.Text = "You are Player 1";
                Turn.Text = "Your Turn";
                OccupyThreeRandomLocation();
            }//end-if
            else //Client
            {
                try
                {
                    getBoard();
                    client = new TcpClient(IP, Port);
                    sock = client.Client;
                    Player.Text = "You are Player 2";
                    Turn.Text = "Opponent's Turn";
                    ReceiveShape();
                    MessageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }//end else
        }
        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e) //receiveData
        {
            if (gameover())
            {
                return;
            }//end-if
            FreezeBoard();
            Turn.Text = "Opponent's Turn";
            ReceiveMove();
            ReceiveScore();

            if (getScoreCheckbord() == 0) ReceiveShape();

            Turn.Text = "Your Turn";
            if (!gameover())
                UnFreezeBoard();
        }
        private void getBoard()
        {
            Grid = new Cell[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Grid[i, j] = new Cell();
                    Grid[i, j].Size = new Size(Cell.BUTTON_HEIGHT, Cell.BUTTON_WIDTH);
                    Grid[i, j].Click += new EventHandler(Button_Click);
                    Grid[i, j].Location = new Point(j * Cell.BUTTON_HEIGHT+10, i * Cell.BUTTON_WIDTH+10);

                    this.Controls.Add(Grid[i, j]);
                }
            }
        }
        public Color GetRandomColorFromSet()
        {
            Random random = new Random();

            int RandomNumber = random.Next(0, colors.Length);

            return colors.ElementAt(RandomNumber);
        }
        public int[] OccupyRandomLocation()
        {
            Random random = new Random();
            int[] ShapeData = new int[3];
            while (true)
            {
                int RowNumber = random.Next(0, 9);
                int ColumnNumber = random.Next(0, 9);
                ShapeData[0] = RowNumber;
                ShapeData[1] = ColumnNumber;
                if (Grid[RowNumber, ColumnNumber].Occupied == false)
                {
                    Color RandomColor = GetRandomColorFromSet();
                    string shape = Shape.Square.Value;

                    Grid[RowNumber, ColumnNumber].ForeColor = RandomColor;
                    Grid[RowNumber, ColumnNumber].Text = shape;
                    Grid[RowNumber, ColumnNumber].Occupied = true;
                    int NumColor = 0;
                    if (RandomColor == Color.Red) NumColor = 1;
                    else if (RandomColor == Color.Green) NumColor = 2;
                    else if (RandomColor == Color.Blue) NumColor = 3;
                    ShapeData[2] = NumColor;
                    return ShapeData;
                }
            }
        }
        public void OccupyThreeRandomLocation()
        {
            int n = 0; // Empty space count
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Grid[i, j].Occupied)
                    {
                        n++;
                    }
                }
            }
            // Check the empty spaces in the board
            if (n > 3)
            {               
                int number = 0;               
                byte[] SendRandLocation = new byte[9];

                for (int k = 0; k < 9; k += 3)
                {
                    int[] Random = new int[3];
                    Random = OccupyRandomLocation();
                    SendRandLocation[k] = (byte)Random[0]; // Row Location
                    SendRandLocation[k + 1] = (byte)Random[1]; // Column Location
                    SendRandLocation[k + 2] = (byte)Random[2]; // Color Number
                    number++;
                }
                sock.Send(SendRandLocation);               
            }
            else if (n == 2)
            {
                int number = 0;
                byte[] SendRandLocation = new byte[6];

                for (int k = 0; k < 6; k += 3)
                {
                    int[] Random = new int[3];
                    Random = OccupyRandomLocation();
                    SendRandLocation[k] = (byte)Random[0]; // Row Location
                    SendRandLocation[k + 1] = (byte)Random[1]; // Column Location
                    SendRandLocation[k + 2] = (byte)Random[2]; // Color Number
                    number++;
                }
                sock.Send(SendRandLocation);
            }
            else
            {
                int number = 0;
                byte[] SendRandLocation = new byte[3];

                for (int k = 0; k < 3; k += 3)
                {
                    int[] Random = new int[3];
                    Random = OccupyRandomLocation();
                    SendRandLocation[k] = (byte)Random[0]; // Row Location
                    SendRandLocation[k + 1] = (byte)Random[1]; // Column Location
                    SendRandLocation[k + 2] = (byte)Random[2]; // Color Number
                    number++;
                }
                sock.Send(SendRandLocation);
            }
        }

        private void FreezeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Grid[i, j].Enabled =false;
                }
            }
        }
        private void UnFreezeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Grid[i, j].Enabled = true;
                }
            }
        }
        private void ReceiveShape() //receiveRandomLocation
        {
            byte[] buffer = new byte[9];
            sock.Receive(buffer);
            for (int i = 0; i < 9; i += 3)
            {
                Color color = new Color();
                if ((int)buffer[i + 2] == 1) color = Color.Red;
                else if ((int)buffer[i + 2] == 2) color = Color.Green;
                else if ((int)buffer[i + 2] == 3) color = Color.Blue;

                Grid[(int)buffer[i], (int)buffer[i + 1]].ForeColor = color;
                Grid[(int)buffer[i], (int)buffer[i + 1]].Text = Shape.Square.Value;
                Grid[(int)buffer[i], (int)buffer[i + 1]].Occupied = true;
            }            
        }
        private int OpponentScore;
        private void ReceiveScore() //Receive Opponent's score
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (Player.Text == "You are Player 1")
            {
                OpponentScore = ((int)buffer[0]);
                Player2Label.Text = "Player 2's Score : "+((int)buffer[0]).ToString();
            }
            else
            {
                OpponentScore = ((int)buffer[0]);
                Player1Label.Text = "Player 1's Score : " + ((int)buffer[0]).ToString();
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
        private void ReceiveMove() //Receive opponent's move
        {
            byte[] buffer = new byte[5]; // 0 = Source Row Number, 1 = Source Column Number, 2 = Destination Row Number, 3 = Destination Column Number, 4 = Color Number
            sock.Receive(buffer);

            if ((int)buffer[4] == 1) colormove = Color.Red;
            else if ((int)buffer[4] == 2) colormove = Color.Green;
            else if ((int)buffer[4] == 3) colormove = Color.Blue;
            List<Index> list = new List<Index>();

            if (shortpath((int)buffer[0], (int)buffer[1], (int)buffer[2], (int)buffer[3], ref list))
            {
                getMove(list);
            }
        }
        private void getMove(List<Index> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int r = list[i].row;
                int c = list[i].col;

                int nr = list[i - 1].row;
                int nc = list[i - 1].col;
                // destination cell
                Grid[nr, nc].ForeColor = colormove;
                Grid[nr, nc].Text = Shape.Square.Value;
                Grid[nr, nc].Occupied = true;
                // start cell
                Grid[r, c].ForeColor = Color.White;
                Grid[r, c].Text = "";
                Grid[r, c].Occupied = false;
                SoundPlayer Sound = new SoundPlayer("../../../SoundEffect/moving.wav");
                Sound.Play();
                Task.Delay(1000).Wait();
            }
        }
        private bool shortpath(int srcX, int srcY, int destX, int destY, ref List<Index> list)
        {
            char[,] grid = new char[9, 9]; // Create a new grid to find shortest without changing anything in the game
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Grid[i, j].Occupied) //empty
                    {
                        grid[i, j] = '1';
                    }
                    if (Grid[i, j].Occupied) //Occupied
                    {
                        grid[i, j] = '0';
                    }
                    if (i == srcX && j == srcY) { grid[i, j] = 's'; } //start
                    if (i == destX && j == destY) { grid[i, j] = 'd'; } //destination
                }
            }
            Index src = new Index(0, 0);
            bool[,] visited = new bool[9, 9]; // Check the occupied buttons in our new grid 
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
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
            indexes.Add(src); // Add starting position to list
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
                if (p.row + 1 < 9 && visited[p.row + 1, p.col] == false)
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
                if (p.col + 1 < 9 && visited[p.row, p.col + 1] == false)
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
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Grid[i, j].Location == button.Location)
                    {
                        row = i;
                        col = j;
                        return;
                    }//end-if
                }//end-for
            }//end-for
        }//end getIndex
        private Color colormove;
        private int YourScore, NumColor;
        private int currrow = 0, currcol = 0, nextrow = 0, nextcol = 0;
        private bool shapeSelected = false;
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            if (button.Text != "") //first click
            {
                getIndex(button, ref currrow, ref currcol);
                //shapemove = button.Text;
                colormove = button.ForeColor;
                if (colormove == Color.Red) NumColor = 1;
                else if(colormove == Color.Green) NumColor = 2;
                else if(colormove == Color.Blue) NumColor = 3;
                shapeSelected = true;
            }//end-if
            else if (button.Text == "" && shapeSelected == true) //Destination click
            {
                getIndex(button, ref nextrow, ref nextcol);
                List<Index> list = new List<Index>();
                if (shortpath(currrow, currcol, nextrow, nextcol, ref list)) // check short path
                {
                    getMove(list); //make move
                    // 0 = Source Row Number, 1 = Source Column Number, 2 = Destination Row Number, 3 = Destination Column Number, 4 = Color Number
                    byte[] SendMove = { (byte)currrow, (byte)currcol, (byte)nextrow, (byte)nextcol, (byte)NumColor };
                    sock.Send(SendMove);

                    int tmp = YourScore;
                    YourScore += getScoreCheckbord(); //get score
                    if (Player.Text == "You are Player 1") //If your player 1
                    {
                        Player1Label.Text = "Player 1's Score : " + YourScore.ToString();
                        byte[] SendScore = { (byte)YourScore };
                        sock.Send(SendScore);
                    }
                    else {  // If you are player 2
                        Player2Label.Text = "Player 2's Score : " + YourScore.ToString();
                        byte[] SendScore = { (byte)YourScore };
                        sock.Send(SendScore);
                    }
                    if (tmp == YourScore) //if no score, random new 3 shape and color
                    {
                        OccupyThreeRandomLocation();
                    }
                    MessageReceiver.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("No path to move");
                }
                shapeSelected = false;
            }//end-else if
        }//end-Button_Click
        private bool gameover()
        {
            int n = 0; // Number of occupied buttons.
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Grid[i, j].Occupied)
                        n++; 
                }//end-for
            }//end-for
            if (n == 9 * 9) // All the buttons are occupied
            {
                string message = "Game Over\n";
                if (YourScore > OpponentScore) message = "You win !\n";
                else if (YourScore < OpponentScore) message = "You lose !\n";
                else message = "Draw !";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, "Game Over", buttons);
                if (result == DialogResult.OK)
                {
                   //After game over do something?
                }
                return true;
            }//end-if
            return false;
        }//end gameover
        public int getScoreCheckbord()
        {
            int score = 0;
            for (int i = 0; i < 9; i++)
            {
                int countHorz = 0, countVert = 0;
                for (int j = 1; j < 9; j++)
                {
                    //check Horz
                    if (Grid[i, j - 1].Text == Grid[i, j].Text && Grid[i, j - 1].ForeColor == Grid[i, j].ForeColor && Grid[i, j].Occupied)
                    {
                        countHorz++;
                        if (countHorz >= 4) // If there is more than 4 same button horizontally update your score
                        {
                            for (int k = j; k > j - 5; k--)
                            {
                                Grid[i, k].ForeColor = Color.White;
                                Grid[i, k].Text = "";
                                Grid[i, k].Occupied = false;
                            }
                            SoundPlayer Sound = new SoundPlayer("../../../SoundEffect/getScore.wav");
                            Sound.Play();
                            score += 3;
                        }
                    }
                    else { countHorz = 0; }
                    //check Vert
                    if (j < 9 && Grid[j - 1, i].Text == Grid[j, i].Text && Grid[j - 1, i].ForeColor == Grid[j, i].ForeColor && Grid[j, i].Occupied)
                    {
                        countVert++;
                        if (countVert >= 4) // If there is more than 4 same button vertically update your score
                        {
                            for (int k = j; k > j - 5; k--)
                            {
                                Grid[k, i].ForeColor = Color.White;
                                Grid[k, i].Text = "";
                                Grid[k, i].Occupied = false;
                            }
                            SoundPlayer Sound = new SoundPlayer("../../../SoundEffect/getScore.wav");
                            Sound.Play();
                            score += 3;
                        }
                    }
                    else { countVert = 0; }
                }
            }
            return score;
        }//end-getScoreCheckbord
    }
}
