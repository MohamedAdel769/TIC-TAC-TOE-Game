using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace TicTacToe
{
    // game for 1 player and Ai 
    public partial class Game1pHard : MetroFramework.Forms.MetroForm
    {
        int player; // player = 1 (x turn) , = 2 (o turn)
        int nButtons;
        int[,] board = new int[3, 3]; // 0--> empty 1--> X 2--> O  
        int xCount, oCount, drawCount;
        Ai Computer = new Ai(); // make a new ai object 

        public Game1pHard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            SoundPlayer Click;

            Button B = (Button)sender;
            string location = B.Name;
            int x = location[1] - '0', y = location[2] - '0';
            if (B.Text.Equals(""))
            {
                nButtons++;
                if (player == 1)
                {
                    Click = new SoundPlayer(TicTacToe.Properties.Resources.Xsound);
                    Click.Play();
                    Thread.Sleep(30);

                    B.Text = "X";
                    B.ForeColor = Color.Red;
                    board[x, y] = player;
                }
                else if (player == 2)
                {
                    Click = new SoundPlayer(TicTacToe.Properties.Resources.Osound);
                    Click.Play();
                    Thread.Sleep(30);

                    B.Text = "O";
                    B.ForeColor = Color.Blue;
                }

                if (player == 1)
                {
                    player = 2;
                }
                else if (player == 2)
                {
                    player = 1;
                }
                isWinner();
                if (player == 2)
                {
                    // get the button which the ai will click it and search for this button over all buttons then click it
                    Thread.Sleep(170);
                    Button btn = Computer.performMove(board);
                    foreach (Control C in panel1.Controls)
                    {
                        Button b = (Button)C;
                        {
                            if (b.Name == btn.Name)
                            {
                                b.PerformClick();
                            }
                        }
                    }
                }
            }

        }

        public void isWinner()
        {
            bool flag = false;

            // horizontal checks 
            if (!flag)
            {
                if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != 0)
                {
                    win_Effect(b00, b01, b02);
                    flag = true;
                }
                else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != 0)
                {
                    win_Effect(b10, b11, b12);
                    flag = true;
                }
                else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != 0)
                {
                    win_Effect(b20, b21, b22);
                    flag = true;
                }
            }

            //Vertical checks
            if (!flag)
            {
                if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != 0)
                {
                    win_Effect(b00, b10, b20);
                    disableButtons();
                    flag = true;
                }
                else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[1, 1] != 0)
                {
                    win_Effect(b01, b11, b21);
                    disableButtons();
                    flag = true;
                }
                else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != 0)
                {
                    win_Effect(b02, b12, b22);
                    disableButtons();
                    flag = true;
                }
            }

            // diagonal check
            if (!flag)
            {
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                {
                    win_Effect(b00, b11, b22);
                    disableButtons();
                    flag = true;
                }
                else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[1, 1] != 0)
                {
                    win_Effect(b02, b11, b20);
                    disableButtons();
                    flag = true;
                }
            }

            if (flag)
                disableButtons();
            else
            {
                if (nButtons == 9)
                {
                    label1.Text = "No Winner ";
                    drawCount++;
                    string s = drawCount + "";
                    DRcount.Text = s;
                    flag = true;

                    SoundPlayer draw_sound = new SoundPlayer(TicTacToe.Properties.Resources.draw);
                    draw_sound.Play();
                }
            }
        }

        private void win_Effect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Green; b2.BackColor = Color.Green; b3.BackColor = Color.Green;
            b1.ForeColor = Color.White; b2.ForeColor = Color.White; b3.ForeColor = Color.White;
            if (b1.Text == "X")
            {
                label1.Text = "Player Wins !";
                xCount++;
                string s = xCount + "";
                Playercount.Text = s;

                SoundPlayer Win_sound = new SoundPlayer(TicTacToe.Properties.Resources.win);
                Win_sound.Play();
            }
            else
            {
                label1.Text = "Computer Wins !";
                oCount++;
                string s = oCount + "";
                Compcount.Text = s;

                SoundPlayer lose_sound = new SoundPlayer(TicTacToe.Properties.Resources.You_lose_sound_effect);
                lose_sound.Play();
            }
        }

        private void disableButtons()
        {
            foreach (Control C in panel1.Controls)
            {
                if (C is Button)
                {
                    C.Enabled = false;
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {

            SoundPlayer click = new SoundPlayer(TicTacToe.Properties.Resources.MenuClick);
            click.Play();

            player = 1;
            label1.Text = "GAME-MODE: HARD";
            nButtons = 0;
            foreach (Control C in panel1.Controls)
            {
                if (C is Button)
                {
                    C.Text = "";
                    C.Enabled = true;
                    C.BackColor = Color.White;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        private void Game1pHard_Load_1(object sender, EventArgs e)
        {
            Computer.init(2); // make the ai play with O 
            transparentColor();
            label1.Text = "GAME-MODE: HARD";
            player = 1;
            nButtons = 0;
            xCount = 0; oCount = 0; drawCount = 0;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            SoundPlayer Click = new SoundPlayer(TicTacToe.Properties.Resources.Exit);
            Click.Play();

            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void transparentColor()
        {
            nOfWins.Parent = pictureBox1;
            nOfWins.BackColor = Color.Transparent;

            nOfLoses.Parent = pictureBox1;
            nOfLoses.BackColor = Color.Transparent;

            nOfDraws.Parent = pictureBox1;
            nOfDraws.BackColor = Color.Transparent;

            Playercount.Parent = pictureBox1;
            Playercount.BackColor = Color.Transparent;

            Compcount.Parent = pictureBox1;
            Compcount.BackColor = Color.Transparent;

            DRcount.Parent = pictureBox1;
            DRcount.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
    }
}
