namespace Trabalho_Final
{
    partial class telaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            this.btFacil = new System.Windows.Forms.Button();
            this.btMedio = new System.Windows.Forms.Button();
            this.btDificil = new System.Windows.Forms.Button();
            this.jogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btFacil
            // 
            this.btFacil.BackColor = System.Drawing.Color.LawnGreen;
            this.btFacil.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacil.Location = new System.Drawing.Point(275, 145);
            this.btFacil.Name = "btFacil";
            this.btFacil.Size = new System.Drawing.Size(151, 61);
            this.btFacil.TabIndex = 1;
            this.btFacil.Text = "Facil";
            this.btFacil.UseVisualStyleBackColor = false;
            this.btFacil.Click += new System.EventHandler(this.btFacil_Click);
            // 
            // btMedio
            // 
            this.btMedio.BackColor = System.Drawing.Color.Yellow;
            this.btMedio.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedio.Location = new System.Drawing.Point(275, 227);
            this.btMedio.Name = "btMedio";
            this.btMedio.Size = new System.Drawing.Size(151, 59);
            this.btMedio.TabIndex = 2;
            this.btMedio.Text = "Medio";
            this.btMedio.UseVisualStyleBackColor = false;
            // 
            // btDificil
            // 
            this.btDificil.BackColor = System.Drawing.Color.Red;
            this.btDificil.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDificil.Location = new System.Drawing.Point(275, 306);
            this.btDificil.Name = "btDificil";
            this.btDificil.Size = new System.Drawing.Size(151, 53);
            this.btDificil.TabIndex = 3;
            this.btDificil.Text = "Dificil";
            this.btDificil.UseVisualStyleBackColor = false;
            // 
            // jogador
            // 
            this.jogador.Location = new System.Drawing.Point(273, 93);
            this.jogador.Name = "jogador";
            this.jogador.Size = new System.Drawing.Size(304, 20);
            this.jogador.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(-2, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Jogador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(193, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genius Colors";
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jogador);
            this.Controls.Add(this.btDificil);
            this.Controls.Add(this.btMedio);
            this.Controls.Add(this.btFacil);
            this.Name = "telaInicial";
            this.Text = "telaInicial";
            this.Load += new System.EventHandler(this.telaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFacil;
        private System.Windows.Forms.Button btMedio;
        private System.Windows.Forms.Button btDificil;
        private System.Windows.Forms.TextBox jogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}