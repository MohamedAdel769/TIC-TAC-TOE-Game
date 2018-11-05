namespace TicTacToe
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Game1P = new MetroFramework.Controls.MetroTile();
            this.Exit = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Livetile1 = new MetroFramework.Controls.MetroTile();
            this.Livetile2 = new MetroFramework.Controls.MetroTile();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Game2P = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Game1P
            // 
            this.Game1P.ActiveControl = null;
            this.Game1P.ForeColor = System.Drawing.Color.Ivory;
            this.Game1P.Location = new System.Drawing.Point(284, 259);
            this.Game1P.Margin = new System.Windows.Forms.Padding(0);
            this.Game1P.Name = "Game1P";
            this.Game1P.Size = new System.Drawing.Size(144, 45);
            this.Game1P.TabIndex = 1;
            this.Game1P.Text = "1P";
            this.Game1P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Game1P.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Game1P.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Game1P.UseSelectable = true;
            this.Game1P.UseStyleColors = true;
            this.Game1P.Click += new System.EventHandler(this.Game1P_Click);
            // 
            // Exit
            // 
            this.Exit.ActiveControl = null;
            this.Exit.ForeColor = System.Drawing.Color.Ivory;
            this.Exit.Location = new System.Drawing.Point(284, 419);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(144, 45);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Quit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Exit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Exit.UseSelectable = true;
            this.Exit.UseStyleColors = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Livetile1
            // 
            this.Livetile1.ActiveControl = null;
            this.Livetile1.Enabled = false;
            this.Livetile1.Location = new System.Drawing.Point(60, 63);
            this.Livetile1.Margin = new System.Windows.Forms.Padding(0);
            this.Livetile1.Name = "Livetile1";
            this.Livetile1.Size = new System.Drawing.Size(128, 128);
            this.Livetile1.Style = MetroFramework.MetroColorStyle.White;
            this.Livetile1.TabIndex = 6;
            this.Livetile1.TileImage = ((System.Drawing.Image)(resources.GetObject("Livetile1.TileImage")));
            this.Livetile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Livetile1.UseCustomBackColor = true;
            this.Livetile1.UseSelectable = true;
            this.Livetile1.UseTileImage = true;
            // 
            // Livetile2
            // 
            this.Livetile2.ActiveControl = null;
            this.Livetile2.Enabled = false;
            this.Livetile2.Location = new System.Drawing.Point(489, 63);
            this.Livetile2.Name = "Livetile2";
            this.Livetile2.Size = new System.Drawing.Size(128, 128);
            this.Livetile2.Style = MetroFramework.MetroColorStyle.White;
            this.Livetile2.TabIndex = 7;
            this.Livetile2.TileImage = ((System.Drawing.Image)(resources.GetObject("Livetile2.TileImage")));
            this.Livetile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Livetile2.UseSelectable = true;
            this.Livetile2.UseTileImage = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(291, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 46);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "T";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Location = new System.Drawing.Point(309, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 46);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "ic";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gold;
            this.textBox3.Location = new System.Drawing.Point(349, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 46);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "T";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox4.Location = new System.Drawing.Point(366, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 46);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "ac";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox5.Location = new System.Drawing.Point(319, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(23, 46);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "T";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox6.Location = new System.Drawing.Point(335, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 46);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "oe";
            // 
            // Game2P
            // 
            this.Game2P.ActiveControl = null;
            this.Game2P.ForeColor = System.Drawing.Color.Ivory;
            this.Game2P.Location = new System.Drawing.Point(284, 339);
            this.Game2P.Margin = new System.Windows.Forms.Padding(0);
            this.Game2P.Name = "Game2P";
            this.Game2P.Size = new System.Drawing.Size(144, 45);
            this.Game2P.TabIndex = 15;
            this.Game2P.Text = "2P";
            this.Game2P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Game2P.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Game2P.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Game2P.UseSelectable = true;
            this.Game2P.UseStyleColors = true;
            this.Game2P.Click += new System.EventHandler(this.Game2P_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 520);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(675, 525);
            this.Controls.Add(this.Game2P);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Livetile2);
            this.Controls.Add(this.Livetile1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Game1P);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile Game1P;
        private MetroFramework.Controls.MetroTile Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroTile Livetile1;
        private MetroFramework.Controls.MetroTile Livetile2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private MetroFramework.Controls.MetroTile Game2P;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

