using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TicTacToe
{
    // this is the Main Menu Form 
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();        
        }
        // after timer1 interval is ended this event occurs and change the current image
        private void timer1_Tick(object sender, EventArgs e)
        {
            // we know the current image from the background color 
          if(Livetile1.BackColor == Color.White)
            {
                Livetile1.BackColor = Color.FromArgb(255,254,254);
                Livetile1.TileImage = Properties.Resources.if_Orkut_1063057;
            }
          else
            {
                Livetile1.TileImage = Properties.Resources.x;
                Livetile1.BackColor = Color.White;
                Livetile1.Refresh(); // redraw the tile (apply the changes)
            }
        }

        // same as timer1_tick 
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Livetile2.BackColor == Color.White)
            {
                Livetile2.BackColor = Color.FromArgb(255, 254, 254);
                Livetile2.TileImage = Properties.Resources.x;

            }
            else
            {
                Livetile2.TileImage = Properties.Resources.if_Orkut_1063057; 
                Livetile2.BackColor = Color.White;
                Livetile2.Refresh();
            }
        }
        // start the timer when the form is loaded 
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        // close the whole app when the user exit the game 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // occurs when the user choose to play vs the computer 
        private void Game1P_Click(object sender, EventArgs e)
        {
            // button click effect 
            SoundPlayer  Click = new SoundPlayer(Properties.Resources.MenuClick);
            Click.Play();
            // ask the user to choose game mode (difficulty)
            Mode dialog = new Mode();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) // check that the user choose a valid choice and hit ok 
            {
                // start the game depend on game mode 
                if(dialog.selectedMode == "Normal")
                {
                    Game1pNormal game = new Game1pNormal();
                    this.Hide();
                    game.Show();
                }
                else if(dialog.selectedMode == "Hard") {
                    Game1pHard game = new Game1pHard();
                    this.Hide();
                    game.Show();
                }
                else
                {
                    Game1pEasy game = new Game1pEasy();
                    this.Hide();
                    game.Show();
                }
            }
        }
        // if the user choose to play with human 
        private void Game2P_Click(object sender, EventArgs e)
        {
            // button click effect
            SoundPlayer Click = new SoundPlayer(Properties.Resources.MenuClick);
            Click.Play();
            // start the game 
            Game2p game = new Game2p();
            this.Hide();
            game.Show();
        }
        // if the user Exit the game 
        private  void Exit_Click(object sender, EventArgs e)
        {
            // button click effect 
            SoundPlayer Click = new SoundPlayer(Properties.Resources.Exit);
            Click.Play();
            Thread.Sleep(390); // wait 390 milliseconds until sound is ended then close the whole app 

            Application.Exit();
        }
    }
}
