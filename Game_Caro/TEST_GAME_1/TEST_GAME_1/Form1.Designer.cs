namespace TEST_GAME_1
{
    partial class Form1
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
            this.banco = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NamePlayer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAINGƯỜICHƠIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHƠIVỚIMAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicPlayer = new System.Windows.Forms.PictureBox();
            this.avata = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avata)).BeginInit();
            this.SuspendLayout();
            // 
            // banco
            // 
            this.banco.BackColor = System.Drawing.SystemColors.Control;
            this.banco.Location = new System.Drawing.Point(6, 30);
            this.banco.Name = "banco";
            this.banco.Size = new System.Drawing.Size(602, 526);
            this.banco.TabIndex = 0;
            this.banco.Paint += new System.Windows.Forms.PaintEventHandler(this.banco_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.avata);
            this.panel2.Location = new System.Drawing.Point(614, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 287);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.PicPlayer);
            this.panel3.Controls.Add(this.NamePlayer);
            this.panel3.Location = new System.Drawing.Point(614, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 242);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caro thu thach tri tue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Game Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NamePlayer
            // 
            this.NamePlayer.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePlayer.Location = new System.Drawing.Point(3, 12);
            this.NamePlayer.Name = "NamePlayer";
            this.NamePlayer.Size = new System.Drawing.Size(175, 30);
            this.NamePlayer.TabIndex = 0;
            this.NamePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hAINGƯỜICHƠIToolStripMenuItem,
            this.cHƠIVỚIMAYToolStripMenuItem,
            this.tHOATToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // hAINGƯỜICHƠIToolStripMenuItem
            // 
            this.hAINGƯỜICHƠIToolStripMenuItem.Name = "hAINGƯỜICHƠIToolStripMenuItem";
            this.hAINGƯỜICHƠIToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.hAINGƯỜICHƠIToolStripMenuItem.Text = "HAI NGƯỜI CHƠI";
            this.hAINGƯỜICHƠIToolStripMenuItem.Click += new System.EventHandler(this.hAINGƯỜICHƠIToolStripMenuItem_Click);
            // 
            // cHƠIVỚIMAYToolStripMenuItem
            // 
            this.cHƠIVỚIMAYToolStripMenuItem.Name = "cHƠIVỚIMAYToolStripMenuItem";
            this.cHƠIVỚIMAYToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.cHƠIVỚIMAYToolStripMenuItem.Text = "CHƠI VỚI MAY";
            this.cHƠIVỚIMAYToolStripMenuItem.Click += new System.EventHandler(this.cHƠIVỚIMAYToolStripMenuItem_Click);
            // 
            // tHOATToolStripMenuItem
            // 
            this.tHOATToolStripMenuItem.Name = "tHOATToolStripMenuItem";
            this.tHOATToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.tHOATToolStripMenuItem.Text = "THOÁT";
            this.tHOATToolStripMenuItem.Click += new System.EventHandler(this.tHOATToolStripMenuItem_Click);
            // 
            // PicPlayer
            // 
            this.PicPlayer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PicPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicPlayer.Location = new System.Drawing.Point(184, 0);
            this.PicPlayer.Name = "PicPlayer";
            this.PicPlayer.Size = new System.Drawing.Size(124, 120);
            this.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer.TabIndex = 2;
            this.PicPlayer.TabStop = false;
            this.PicPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // avata
            // 
            this.avata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avata.BackgroundImage = global::TEST_GAME_1.Properties.Resources.Red_X_Icon;
            this.avata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avata.Location = new System.Drawing.Point(1, 3);
            this.avata.Name = "avata";
            this.avata.Size = new System.Drawing.Size(307, 282);
            this.avata.TabIndex = 0;
            this.avata.TabStop = false;
            this.avata.Click += new System.EventHandler(this.avata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 564);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.banco);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel banco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox avata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PicPlayer;
        private System.Windows.Forms.TextBox NamePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAINGƯỜICHƠIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHƠIVỚIMAYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOATToolStripMenuItem;
    }
}

