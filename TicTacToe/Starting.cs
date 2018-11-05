using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    // This is a splash screen form
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        Timer loadingTime; // make a timer to specify the time showing form 


        /*this is an event occurs when the form is shown 
         *  set timer interval in millisecond 
         *  start the timer
         *  wait until timer tick which indicates that timer has ended 
         *  then raises an event     
         */
        private void Starting_Shown(object sender, EventArgs e)
        {      
            loadingTime = new Timer();
            loadingTime.Interval = 5000;
            loadingTime.Start();
            loadingTime.Tick += new EventHandler(loadingTime_Tick); 
         }

        /* this function occurs when the timer interval ended 
         * stop timer 
         * then show the Main Form (MENU)
         */
        void loadingTime_Tick(object sender,EventArgs e)
        {
            loadingTime.Stop();
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Starting_Load(object sender, EventArgs e)
        {
            // make the text background color transparent 
            loadinglabel.BackColor = Color.FromArgb(0, Color.Black);
            creditlabel.BackColor = Color.FromArgb(0, Color.Black);
        }
    }
}
