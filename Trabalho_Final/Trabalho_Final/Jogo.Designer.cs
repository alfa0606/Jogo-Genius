namespace Trabalho_Final
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.btnRed = new System.Windows.Forms.PictureBox();
            this.btnBlue = new System.Windows.Forms.PictureBox();
            this.btnYellow = new System.Windows.Forms.PictureBox();
            this.btnGreen = new System.Windows.Forms.PictureBox();
            this.Jogar = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.geniusColors = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pontosMarc = new System.Windows.Forms.Label();
            this.botao_sobre = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.joga2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGreen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joga2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(216, 119);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(119, 97);
            this.btnRed.TabIndex = 0;
            this.btnRed.TabStop = false;
            this.btnRed.Click += new System.EventHandler(this.red_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(216, 233);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(119, 104);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.TabStop = false;
            this.btnBlue.Click += new System.EventHandler(this.blue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(362, 233);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(111, 104);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.TabStop = false;
            this.btnYellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Location = new System.Drawing.Point(362, 119);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(111, 97);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.TabStop = false;
            this.btnGreen.Click += new System.EventHandler(this.green_Click);
            // 
            // Jogar
            // 
            this.Jogar.BackColor = System.Drawing.Color.White;
            this.Jogar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jogar.Location = new System.Drawing.Point(17, 119);
            this.Jogar.Name = "Jogar";
            this.Jogar.Size = new System.Drawing.Size(90, 41);
            this.Jogar.TabIndex = 4;
            this.Jogar.Text = "Jogar!";
            this.Jogar.UseVisualStyleBackColor = false;
            this.Jogar.Click += new System.EventHandler(this.Clique);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Showcard Gothic", 8.2F);
            this.menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu.Location = new System.Drawing.Point(24, 327);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(90, 41);
            this.menu.TabIndex = 5;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // geniusColors
            // 
            this.geniusColors.BackColor = System.Drawing.Color.Black;
            this.geniusColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.geniusColors.Font = new System.Drawing.Font("Showcard Gothic", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geniusColors.ForeColor = System.Drawing.Color.Red;
            this.geniusColors.Location = new System.Drawing.Point(59, 29);
            this.geniusColors.Name = "geniusColors";
            this.geniusColors.Size = new System.Drawing.Size(396, 59);
            this.geniusColors.TabIndex = 1;
            this.geniusColors.TabStop = false;
            this.geniusColors.Text = "Genius Colors";
            this.geniusColors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.geniusColors.WordWrap = false;
            this.geniusColors.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(451, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pontosMarc
            // 
            this.pontosMarc.AutoSize = true;
            this.pontosMarc.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontosMarc.ForeColor = System.Drawing.Color.White;
            this.pontosMarc.Location = new System.Drawing.Point(24, 258);
            this.pontosMarc.Name = "pontosMarc";
            this.pontosMarc.Size = new System.Drawing.Size(113, 26);
            this.pontosMarc.TabIndex = 7;
            this.pontosMarc.Text = "Pontos:";
            // 
            // botao_sobre
            // 
            this.botao_sobre.BackColor = System.Drawing.Color.White;
            this.botao_sobre.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_sobre.Location = new System.Drawing.Point(17, 175);
            this.botao_sobre.Name = "botao_sobre";
            this.botao_sobre.Size = new System.Drawing.Size(90, 41);
            this.botao_sobre.TabIndex = 8;
            this.botao_sobre.Text = "Sobre";
            this.botao_sobre.UseVisualStyleBackColor = false;
            this.botao_sobre.Click += new System.EventHandler(this.botao_sobre_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcaoToolStripMenuItem
            // 
            this.opcaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciar});
            this.opcaoToolStripMenuItem.Name = "opcaoToolStripMenuItem";
            this.opcaoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.opcaoToolStripMenuItem.Text = "opcao";
            // 
            // iniciar
            // 
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(101, 22);
            this.iniciar.Text = "iniciar";
            this.iniciar.Click += new System.EventHandler(this.opcao);
            // 
            // joga2
            // 
            this.joga2.BackColor = System.Drawing.Color.Silver;
            this.joga2.Location = new System.Drawing.Point(113, 94);
            this.joga2.Name = "joga2";
            this.joga2.Size = new System.Drawing.Size(100, 50);
            this.joga2.TabIndex = 10;
            this.joga2.TabStop = false;
            this.joga2.Click += new System.EventHandler(this.Clique);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 387);
            this.Controls.Add(this.joga2);
            this.Controls.Add(this.botao_sobre);
            this.Controls.Add(this.pontosMarc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geniusColors);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.Jogar);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Jogo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jogo_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btnRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGreen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joga2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox amarelo;
        private System.Windows.Forms.PictureBox vermelho;
        private System.Windows.Forms.PictureBox azul;
        private System.Windows.Forms.PictureBox verde;
        private System.Windows.Forms.Button jogarfacil;
        private System.Windows.Forms.PictureBox btnRed;
        private System.Windows.Forms.PictureBox btnBlue;
        private System.Windows.Forms.PictureBox btnYellow;
        private System.Windows.Forms.PictureBox btnGreen;
        private System.Windows.Forms.Button Jogar;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.TextBox geniusColors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pontosMarc;
        private System.Windows.Forms.Button botao_sobre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciar;
        private System.Windows.Forms.PictureBox joga2;
    }
}

