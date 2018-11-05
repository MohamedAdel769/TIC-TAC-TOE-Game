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
{   // Game mode choices 
    public partial class Mode : MetroFramework.Forms.MetroForm
    {
        // to know what mode the player choose  
        public string selectedMode { get; set; }
        public Mode()
        {
            InitializeComponent();
        }
        // set the name of the chosen mode
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedMode = radioButton3.Text;
        }
    }
}
