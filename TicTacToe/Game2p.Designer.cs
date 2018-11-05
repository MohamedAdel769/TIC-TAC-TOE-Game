namespace TicTacToe
{
    partial class Game2p
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2p));
            this.menulink = new MetroFramework.Controls.MetroLink();
            this.b00 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b21 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b01 = new System.Windows.Forms.Button();
            this.b02 = new System.Windows.Forms.Button();
            this.Turn = new System.Windows.Forms.Label();
            this.nOfWins = new System.Windows.Forms.Label();
            this.nOfLoses = new System.Windows.Forms.Label();
            this.nOfDraws = new System.Windows.Forms.Label();
            this.Xcount = new System.Windows.Forms.Label();
            this.Ocount = new System.Windows.Forms.Label();
            this.Drawcount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetbtn = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menulink
            // 
            this.menulink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menulink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menulink.BackgroundImage")));
            this.menulink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menulink.ImageSize = 48;
            this.menulink.Location = new System.Drawing.Point(26, 44);
            this.menulink.Margin = new System.Windows.Forms.Padding(0);
            this.menulink.Name = "menulink";
            this.menulink.Size = new System.Drawing.Size(48, 48);
            this.menulink.TabIndex = 7;
            this.menulink.UseSelectable = true;
            this.menulink.Click += new System.EventHandler(this.menulink_Click);
            // 
            // b00
            // 
            this.b00.BackColor = System.Drawing.Color.White;
            this.b00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b00.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b00.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b00.Location = new System.Drawing.Point(-2, 0);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(106, 96);
            this.b00.TabIndex = 25;
            this.b00.UseVisualStyleBackColor = false;
            this.b00.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::TicTacToe.Properties.Resources.rsz_wood_background_whr_web_hig1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.b21);
            this.panel1.Controls.Add(this.b22);
            this.panel1.Controls.Add(this.b20);
            this.panel1.Controls.Add(this.b11);
            this.panel1.Controls.Add(this.b12);
            this.panel1.Controls.Add(this.b10);
            this.panel1.Controls.Add(this.b01);
            this.panel1.Controls.Add(this.b02);
            this.panel1.Controls.Add(this.b00);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(189, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 289);
            this.panel1.TabIndex = 31;
            // 
            // b21
            // 
            this.b21.BackColor = System.Drawing.Color.White;
            this.b21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b21.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b21.Location = new System.Drawing.Point(104, 192);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(106, 96);
            this.b21.TabIndex = 32;
            this.b21.UseVisualStyleBackColor = false;
            this.b21.Click += new System.EventHandler(this.Button_Click);
            // 
            // b22
            // 
            this.b22.BackColor = System.Drawing.Color.White;
            this.b22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b22.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b22.Location = new System.Drawing.Point(210, 192);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(106, 96);
            this.b22.TabIndex = 33;
            this.b22.UseVisualStyleBackColor = false;
            this.b22.Click += new System.EventHandler(this.Button_Click);
            // 
            // b20
            // 
            this.b20.BackColor = System.Drawing.Color.White;
            this.b20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b20.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b20.Location = new System.Drawing.Point(-2, 192);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(106, 96);
            this.b20.TabIndex = 31;
            this.b20.UseVisualStyleBackColor = false;
            this.b20.Click += new System.EventHandler(this.Button_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.White;
            this.b11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b11.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b11.Location = new System.Drawing.Point(104, 96);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(106, 96);
            this.b11.TabIndex = 29;
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.Button_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.White;
            this.b12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b12.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b12.Location = new System.Drawing.Point(210, 96);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(106, 96);
            this.b12.TabIndex = 30;
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.Button_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.White;
            this.b10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b10.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b10.Location = new System.Drawing.Point(-2, 96);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(106, 96);
            this.b10.TabIndex = 28;
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.Button_Click);
            // 
            // b01
            // 
            this.b01.BackColor = System.Drawing.Color.White;
            this.b01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b01.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b01.Location = new System.Drawing.Point(104, 0);
            this.b01.Name = "b01";
            this.b01.Size = new System.Drawing.Size(106, 96);
            this.b01.TabIndex = 26;
            this.b01.UseVisualStyleBackColor = false;
            this.b01.Click += new System.EventHandler(this.Button_Click);
            // 
            // b02
            // 
            this.b02.BackColor = System.Drawing.Color.White;
            this.b02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.b02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b02.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b02.Location = new System.Drawing.Point(210, 0);
            this.b02.Name = "b02";
            this.b02.Size = new System.Drawing.Size(106, 96);
            this.b02.TabIndex = 27;
            this.b02.UseVisualStyleBackColor = false;
            this.b02.Click += new System.EventHandler(this.Button_Click);
            // 
            // Turn
            // 
            this.Turn.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.ForeColor = System.Drawing.Color.White;
            this.Turn.Location = new System.Drawing.Point(166, 44);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(295, 44);
            this.Turn.TabIndex = 32;
            this.Turn.Text = "  Play";
            // 
            // nOfWins
            // 
            this.nOfWins.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOfWins.ForeColor = System.Drawing.Color.White;
            this.nOfWins.Location = new System.Drawing.Point(185, 439);
            this.nOfWins.Name = "nOfWins";
            this.nOfWins.Size = new System.Drawing.Size(100, 23);
            this.nOfWins.TabIndex = 34;
            this.nOfWins.Text = "X-Wins";
            this.nOfWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nOfLoses
            // 
            this.nOfLoses.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOfLoses.ForeColor = System.Drawing.Color.White;
            this.nOfLoses.Location = new System.Drawing.Point(295, 439);
            this.nOfLoses.Name = "nOfLoses";
            this.nOfLoses.Size = new System.Drawing.Size(100, 23);
            this.nOfLoses.TabIndex = 35;
            this.nOfLoses.Text = "O-Wins";
            this.nOfLoses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nOfDraws
            // 
            this.nOfDraws.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOfDraws.ForeColor = System.Drawing.Color.White;
            this.nOfDraws.Location = new System.Drawing.Point(405, 439);
            this.nOfDraws.Name = "nOfDraws";
            this.nOfDraws.Size = new System.Drawing.Size(100, 23);
            this.nOfDraws.TabIndex = 36;
            this.nOfDraws.Text = "Draw";
            this.nOfDraws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Xcount
            // 
            this.Xcount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xcount.ForeColor = System.Drawing.Color.White;
            this.Xcount.Location = new System.Drawing.Point(185, 462);
            this.Xcount.Name = "Xcount";
            this.Xcount.Size = new System.Drawing.Size(100, 40);
            this.Xcount.TabIndex = 37;
            this.Xcount.Text = "0";
            this.Xcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ocount
            // 
            this.Ocount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocount.ForeColor = System.Drawing.Color.White;
            this.Ocount.Location = new System.Drawing.Point(295, 462);
            this.Ocount.Name = "Ocount";
            this.Ocount.Size = new System.Drawing.Size(100, 40);
            this.Ocount.TabIndex = 38;
            this.Ocount.Text = "0";
            this.Ocount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Drawcount
            // 
            this.Drawcount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drawcount.ForeColor = System.Drawing.Color.White;
            this.Drawcount.Location = new System.Drawing.Point(405, 462);
            this.Drawcount.Name = "Drawcount";
            this.Drawcount.Size = new System.Drawing.Size(100, 40);
            this.Drawcount.TabIndex = 39;
            this.Drawcount.Text = "0";
            this.Drawcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 511);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // resetbtn
            // 
            this.resetbtn.ActiveControl = null;
            this.resetbtn.Location = new System.Drawing.Point(488, 48);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(0);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(111, 44);
            this.resetbtn.TabIndex = 41;
            this.resetbtn.Text = "Play again";
            this.resetbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetbtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.resetbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.resetbtn.UseSelectable = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Game2p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 512);
            this.ControlBox = false;
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.Drawcount);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.Ocount);
            this.Controls.Add(this.Xcount);
            this.Controls.Add(this.nOfDraws);
            this.Controls.Add(this.nOfLoses);
            this.Controls.Add(this.nOfWins);
            this.Controls.Add(this.menulink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game2p";
            this.Padding = new System.Windows.Forms.Padding(60, 60, 60, 60);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Load += new System.EventHandler(this.Game2p_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink menulink;
        private System.Windows.Forms.Button b00;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b01;
        private System.Windows.Forms.Button b02;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b20;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label nOfWins;
        private System.Windows.Forms.Label nOfLoses;
        private System.Windows.Forms.Label nOfDraws;
        private System.Windows.Forms.Label Xcount;
        private System.Windows.Forms.Label Ocount;
        private System.Windows.Forms.Label Drawcount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile resetbtn;
    }
}