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

namespace TicTacToe 
{ // game for 2 players 
    public partial class Game2p : MetroFramework.Forms.MetroForm
    {
        bool XorO; // true = X turn , false = O turn
        int nButtons; // to check if the game ended with draw or not
        string[,] gameBoard = new string[3, 3]; // the game board 
        int xCount, oCount, drawCount; // the score for the 2 players
        public Game2p()
        {
            InitializeComponent();
        }

        // initialize variables and game board at the beginning
        private void Game2p_Load(object sender, EventArgs e)
        {
            transparentColor(); // change all texts background color to transparent
            XorO = true; 
            nButtons = 0;
            xCount = 0;
            oCount = 0;
            drawCount = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[j, i] = "-1";
                }
            }
        }
        // when a player hit a button 
        private void Button_Click(object sender, EventArgs e)
        {
            SoundPlayer Click; // for x and o click effect 

            Button B = (Button)sender;
            string location = B.Name; // get the location of the button that was clicked  
            int x = location[1] - '0', y = location[2] - '0'; // x = row , y = col 
            if (B.Text.Equals("")) // check if this button is empty or not 
            {
                nButtons++; // increment number of buttons clicked 
                // check who's turn and change both button text (X-O) and color and update gameboard  
                if (XorO)
                {
                    Click = new SoundPlayer(TicTacToe.Properties.Resources.Xsound);
                    Click.Play();

                    B.Text = "X";
                    B.ForeColor = Color.Red;
                    gameBoard[x, y] = "X";
                    Turn.Text = "Turn: O-Player";
                    Turn.ForeColor = Color.FromArgb(0, 27, 162);
                }
                else
                {
                    Click = new SoundPlayer(TicTacToe.Properties.Resources.Osound);
                    Click.Play();

                    B.Text = "O";
                    B.ForeColor = Color.Blue;
                    gameBoard[x, y] = "O";
                    Turn.Text = "Turn: X-Player";
                    Turn.ForeColor = Color.FromArgb(210, 0, 0);
                }
                XorO = !XorO; // change the current player (if x --> o) (if o --> x)
                isWinner(); 
            }
        }
        // see if one of the players win or no winner or Draw
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

            if (found) // there is a winner so we disableButtons as the game is ended 
            {
                disableButtons();    
            }
            else
            {   // there isn't a winner so check if it's draw  
                if (nButtons == 9)
                {
                    disableButtons();
                    Turn.Text = "No Winner ";
                    Turn.ForeColor = Color.White;
                    drawCount++; // update number of draw 
                    string s = drawCount.ToString();
                    Drawcount.Text = s;

                    SoundPlayer draw_sound = new SoundPlayer(TicTacToe.Properties.Resources.draw);
                    draw_sound.Play();
                }
            }
        }
        /* if there is a winner
         * change the 3 in row buttons background color green and the text to white
         * update number of Wins for X or O depend on who won 
         */  
        private void win_Effect(Button b1,Button b2,Button b3)
        {
            b1.BackColor = Color.Green; b2.BackColor = Color.Green; b3.BackColor = Color.Green;
            b1.ForeColor = Color.White; b2.ForeColor = Color.White; b3.ForeColor = Color.White;
            if(b1.Text == "X")
            {
                Turn.Text = "X Wins !";
                Turn.ForeColor = Color.FromArgb(210, 0, 0);
                xCount++;
                string s = xCount + "";
                Xcount.Text = s;

                SoundPlayer Win_sound = new SoundPlayer(TicTacToe.Properties.Resources.win);
                Win_sound.Play();
            }
            else
            {
                Turn.Text = "O Wins !";
                Turn.ForeColor = Color.FromArgb(0, 27, 162);
                oCount++;
                string s = oCount + "";
                Ocount.Text = s;

                SoundPlayer Win_sound = new SoundPlayer(TicTacToe.Properties.Resources.win);
                Win_sound.Play();
            }
        }
        /* iterate over all buttons and disable it to prevent the player from play when the game is already ended 
        * and reset the game board to empty cells 
        */
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
        // link to the main menu 
        private void menulink_Click(object sender, EventArgs e)
        {
            SoundPlayer Click = new SoundPlayer(TicTacToe.Properties.Resources.Exit);
            Click.Play();

            Main main = new Main();
            this.Close();
            main.Show();
        }
        /* if the players wants to continue to play with each other again
         * so reset values and game board
         * enable buttons and reset text color
         */  
        private void resetbtn_Click(object sender, EventArgs e)
        {
            SoundPlayer click = new SoundPlayer(TicTacToe.Properties.Resources.MenuClick);
            click.Play();

            nButtons = 0;
            Turn.Text = "Play";
            Turn.ForeColor = Color.White;
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
        // change all text's color to be transparent 
        private void transparentColor()
        {
            nOfWins.Parent = pictureBox1;
            nOfWins.BackColor = Color.Transparent;

            nOfLoses.Parent = pictureBox1;
            nOfLoses.BackColor = Color.Transparent;

            nOfDraws.Parent = pictureBox1;
            nOfDraws.BackColor = Color.Transparent;

            Xcount.Parent = pictureBox1;
            Xcount.BackColor = Color.Transparent;

            Ocount.Parent = pictureBox1;
            Ocount.BackColor = Color.Transparent;

            Drawcount.Parent = pictureBox1;
            Drawcount.BackColor = Color.Transparent;

            Turn.Parent = pictureBox1;
            Turn.BackColor = Color.Transparent;
        }       
    }
}
