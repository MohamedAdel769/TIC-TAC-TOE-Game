using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    /* game for 1 player and Ai , Game mode easy 
     * this is similar to game2p form so we will skip the repeated things 
     */ 
    public partial class Game1pNormal : MetroFramework.Forms.MetroForm
    {
        bool XorO;
        int nButtons;
        string[,] gameBoard = new string[3, 3];
        int xCount, oCount, drawCount;
        public Game1pNormal()
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
                if (XorO) // player turn 
                {
                    Click = new SoundPlayer(TicTacToe.Properties.Resources.Xsound);
                    Click.Play();
                    Thread.Sleep(30); // wait untill sound is end 

                    B.Text = "X";
                    B.ForeColor = Color.Red;
                    gameBoard[x, y] = "X";
                }
                else // computer turn 
                {
                    Click = new SoundPlayer(TicTacToe.Properties.Resources.Osound);
                    Click.Play();
                    Thread.Sleep(30); // wait until sound is end 

                    B.ForeColor = Color.Blue;
                    gameBoard[x, y] = "O";
                    B.Text = "O";
                }
                XorO = !XorO;
                isWinner();
                
                if (!XorO)
                {
                    Thread.Sleep(170); // make a time between x and o 
                    Com_Move(); // its computer turn so we we go to choose a button to click
                }
            }
        }

        public void Com_Move()
        {
            /* check for 
            *  1- win or block
            *  2- check center pos 
            *  3- corner 
            *  4- free space 
            */  

            Button Where_To_Move = null;
            bool stop = false;
            Where_To_Move = Win_Or_Block("O");
            if (Where_To_Move == null)
            {
                Where_To_Move = Win_Or_Block("X");
                if (Where_To_Move == null)
                {
                    Where_To_Move = Center_Method();
                    if (Where_To_Move == null)
                    {
                        Where_To_Move = Corner_Method();
                        if (Where_To_Move == null)
                        {
                            Where_To_Move = Free_Space();
                            if (Where_To_Move == null)
                            {
                                stop = true;
                            }
                        }
                    }
                }
            }

            if (!stop)
                Where_To_Move.PerformClick(); // after we get the button we click on it 
        }
        // iterate over all buttons and pick up a empty one 
        public Button Free_Space()
        {
            foreach (Control C in panel1.Controls)
            {
                if (C is Button)
                {
                    Button b = (Button)C;
                    if (b.Text == "")
                    {
                        return b; // return the empty button if found else return null
                    }
                }
            }
            return null; 
        }
        // check the button at the center if it empty 
        public Button Center_Method()
        {
            if (b11.Text.Equals(""))
            {
                return b11;
            }
            return null;
        }
        // check all four corners and pick up the empty one 
        public Button Corner_Method()
        {
            if (gameBoard[0, 0] == "O")
            {
                if (gameBoard[0, 2] == "-1")
                    return b02;
                if (gameBoard[2, 2] == "-1")
                    return b22;
                if (gameBoard[2, 0] == "-1")
                    return b20;
            }
            if (gameBoard[0, 2] == "O")
            {
                if (gameBoard[0, 0] == "-1")
                    return b00;
                if (gameBoard[2, 2] == "-1")
                    return b22;
                if (gameBoard[2, 0] == "-1")
                    return b20;
            }
            if (gameBoard[2, 2] == "O")
            {
                if (gameBoard[0, 2] == "-1")
                    return b02;
                if (gameBoard[0, 0] == "-1")
                    return b00;
                if (gameBoard[2, 0] == "-1")
                    return b20;
            }
            if (gameBoard[2, 0] == "O")
            {
                if (gameBoard[0, 2] == "-1")
                    return b02;
                if (gameBoard[2, 2] == "-1")
                    return b22;
                if (gameBoard[0, 0] == "-1")
                    return b00;
            }
            return null;
        }
        // check if there is a move to win or move to block player from win 
        public Button Win_Or_Block(string s)
        {
            // horizontal tests
            if ((gameBoard[0, 0] == gameBoard[0, 1] && gameBoard[0, 1] == s) || (gameBoard[0, 0] == gameBoard[0, 2] && gameBoard[0, 0] == s) || (gameBoard[0, 1] == gameBoard[0, 2] && gameBoard[0, 1] == s))
            {
                if (gameBoard[0, 2] == "-1")
                    return b02;
                if (gameBoard[0, 0] == "-1")
                    return b00;
                if (gameBoard[0, 1] == "-1")
                    return b01;
            }
            if ((gameBoard[1, 0] == gameBoard[1, 1] && gameBoard[1, 1] == s) || (gameBoard[1, 1] == gameBoard[1, 2] && gameBoard[1, 1] == s) || (gameBoard[1, 0] == gameBoard[1, 2] && gameBoard[1, 0] == s))
            {
                if (gameBoard[1, 2] == "-1")
                    return b12;
                if (gameBoard[1, 0] == "-1")
                    return b10;
                if (gameBoard[1, 1] == "-1")
                    return b11;
            }
            if ((gameBoard[2, 0] == gameBoard[2, 1] && gameBoard[2, 1] == s) || (gameBoard[2, 0] == gameBoard[2, 2] && gameBoard[2, 2] == s) || (gameBoard[2, 1] == gameBoard[2, 2] && gameBoard[2, 1] == s))
            {
                if (gameBoard[2, 2] == "-1")
                    return b22;
                if (gameBoard[2, 0] == "-1")
                    return b20;
                if (gameBoard[2, 1] == "-1")
                    return b21;
            }

            // Vertical tests 
            if ((gameBoard[0, 0] == gameBoard[1, 0] && gameBoard[1, 0] == s) || (gameBoard[0, 0] == gameBoard[2, 0] && gameBoard[0, 0] == s) || (gameBoard[1, 0] == gameBoard[2, 0] && gameBoard[1, 0] == s))
            {
                if (gameBoard[2, 0] == "-1")
                    return b20;
                if (gameBoard[0, 0] == "-1")
                    return b00;
                if (gameBoard[1, 0] == "-1")
                    return b10;
            }
            if ((gameBoard[0, 1] == gameBoard[1, 1] && gameBoard[1, 1] == s) || (gameBoard[1, 1] == gameBoard[2, 1] && gameBoard[1, 1] == s) || (gameBoard[0, 1] == gameBoard[2, 1] && gameBoard[0, 1] == s))
            {
                if (gameBoard[2, 1] == "-1")
                    return b21;
                if (gameBoard[0, 1] == "-1")
                    return b01;
                if (gameBoard[1, 1] == "-1")
                    return b11;
            }
            if ((gameBoard[0, 2] == gameBoard[1, 2] && gameBoard[1, 2] == s) || (gameBoard[0, 2] == gameBoard[2, 2] && gameBoard[2, 2] == s) || (gameBoard[1, 2] == gameBoard[2, 2] && gameBoard[1, 2] == s))
            {
                if (gameBoard[2, 2] == "-1")
                    return b22;
                if (gameBoard[0, 2] == "-1")
                    return b02;
                if (gameBoard[1, 2] == "-1")
                    return b12;
            }

            // diagonal tests 
            if ((gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == s) || (gameBoard[0, 0] == gameBoard[2, 2] && gameBoard[2, 2] == s) || (gameBoard[2, 2] == gameBoard[1, 1] && gameBoard[1, 1] == s))
            {
                if (gameBoard[2, 2] == "-1")
                    return b22;
                if (gameBoard[1, 1] == "-1")
                    return b11;
                if (gameBoard[0, 0] == "-1")
                    return b00;
            }
            if ((gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == s) || (gameBoard[0, 2] == gameBoard[2, 0] && gameBoard[2, 0] == s) || (gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[1, 1] == s))
            {
                if (gameBoard[2, 0] == "-1")
                    return b20;
                if (gameBoard[0, 2] == "-1")
                    return b02;
                if (gameBoard[1, 1] == "-1")
                    return b11;
            }
            return null;
        }

        public void isWinner()
        {
            bool found = false;

            // horizontal checks 
            if (gameBoard[0, 0] == gameBoard[0, 1] && gameBoard[0, 1] == gameBoard[0, 2] && gameBoard[0, 0] != "-1")
            {
                found = true;
                win_Effect(b00, b01, b02);
            }
            else if (gameBoard[1, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[1, 2] && gameBoard[1, 0] != "-1")
            {
                found = true;
                win_Effect(b10, b11, b12);
            }
            else if (gameBoard[2, 0] == gameBoard[2, 1] && gameBoard[2, 1] == gameBoard[2, 2] && gameBoard[2, 0] != "-1")
            {
                found = true;
                win_Effect(b20, b21, b22);
            }

            //Vertical checks
            if (gameBoard[0, 0] == gameBoard[1, 0] && gameBoard[1, 0] == gameBoard[2, 0] && gameBoard[0, 0] != "-1")
            {
                found = true;
                win_Effect(b00, b10, b20);
            }
            else if (gameBoard[0, 1] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 1] && gameBoard[1, 1] != "-1")
            {
                found = true;
                win_Effect(b01, b11, b21);
            }
            else if (gameBoard[0, 2] == gameBoard[1, 2] && gameBoard[1, 2] == gameBoard[2, 2] && gameBoard[0, 2] != "-1")
            {
                found = true;
                win_Effect(b02, b12, b22);
            }

            // diagonal check 
            if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[0, 0] != "-1")
            {
                found = true;
                win_Effect(b00, b11, b22);
            }
            else if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[1, 1] != "-1")
            {
                found = true;
                win_Effect(b02, b11, b20);
            }

            if (found)
            {
                disableButtons();
            }
            else
            {
                if (nButtons == 9)
                {
                    label1.Text = "No Winner ";
                    drawCount++;
                    string s = drawCount + "";
                    DRcount.Text = s;

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

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[j, i] = "-1";
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer click = new SoundPlayer(TicTacToe.Properties.Resources.MenuClick);
            click.Play();

            XorO = true;
            nButtons = 0;
            label1.Text = "GAME-MODE: Normal";
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
                    gameBoard[j, i] = "-1";
                }
            }
        }

        private void Game1p_Load(object sender, EventArgs e)
        {
            transparentColor();
            XorO = true; // true = x turn , false = o turn  
            nButtons = 0;
            xCount = 0;
            oCount = 0;
            drawCount = 0;
            label1.Text = "GAME-MODE: Normal";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[j, i] = "-1";
                }
            }
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
