using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Trabalho_Final
{
    public partial class Jogo : Form
    {
        List<string> sequenciaCores = new List<string>();
        List<string> sequenciaJogador = new List<string>();
        int listaIndex, pontos;
        const float brilho = 1.0f;
        string atualCor;
        string[] cores = { "red", "green", "blue", "yellow" };
        bool podeJogar;
        SoundPlayer[] audios = { new SoundPlayer(Properties.Resources.aiai2), new SoundPlayer(Properties.Resources.morri), new SoundPlayer(Properties.Resources.faleceu), new SoundPlayer(Properties.Resources.eutambem), new SoundPlayer(Properties.Resources.errou2) };
        Random mistura = new Random();
        List<int> ClicksJG = new List<int>();
        PictureBox pb;



        public Jogo()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath vermelho = new GraphicsPath();
            vermelho.AddEllipse(0, 0, btnRed.Width, btnRed.Height);
            btnRed.Region = new Region(vermelho);
            GraphicsPath verde = new GraphicsPath();
            verde.AddEllipse(0, 0, btnGreen.Width, btnGreen.Height);
            btnGreen.Region = new Region(verde);
            GraphicsPath azul = new GraphicsPath();
            azul.AddEllipse(0, 0, btnBlue.Width, btnBlue.Height);
            btnBlue.Region = new Region(azul);
            GraphicsPath amarelho = new GraphicsPath();
            amarelho.AddEllipse(0, 0, btnYellow.Width, btnYellow.Height);
            btnYellow.Region = new Region(amarelho);
        }
        
        private void piscarCor(PictureBox bolinha, Color corClara, Color corEscura, SoundPlayer meme)
        {
            bolinha.BackColor = corClara;
            meme.Play();
            Application.DoEvents();
            Thread.Sleep(900);
            bolinha.BackColor = corEscura;
        }

        private void procurarBolinha(string tagBolinha)
        {
            foreach (var bolinhaEncontrada in Controls.OfType<PictureBox>())
            {
                if (bolinhaEncontrada.ToString() == tagBolinha)
                {
                    string tagSom = bolinhaEncontrada.ToString();
                    Color brilhar = ControlPaint.Light(bolinhaEncontrada.BackColor, brilho);
                    SoundPlayer som = tagSom == "red" ? audios[0] : (tagSom == "green" ? audios[1] : (tagSom == "blue" ? audios[2] : audios[3]));
                    piscarCor(bolinhaEncontrada, brilhar, bolinhaEncontrada.BackColor, som);
                }
            }
        }

        private void sortearCor()
        {
            atualCor = cores[mistura.Next(0, 4)];
            sequenciaCores.Add(atualCor);
            foreach (var cor in sequenciaCores)
            {
                procurarBolinha(cor);
                switch (atualCor)
                {
                    case "red":
                        piscarCor(btnRed, Color.OrangeRed, Color.DarkRed, audios[0]);
                        verificar();
                        break;
                    case "green":
                        piscarCor(btnGreen, Color.GreenYellow, Color.DarkGreen, audios[1]);
                        verificar();
                        break;
                    case "blue":
                        piscarCor(btnBlue, Color.LightBlue, Color.DarkBlue, audios[2]);
                        verificar();
                        break;
                    case "yellow":
                        piscarCor(btnYellow, Color.LightYellow, Color.Yellow, audios[3]);
                        verificar();
                        break;

                    default:
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(250);
            }
            podeJogar = true;
        }

       
        private void Clique(object sender, EventArgs e)
        {
            pontos = 0;
            podeJogar = false;
            pontosMarc.Text = "Pontos";
            sequenciaCores.Clear();
            sequenciaJogador.Clear();
            listaIndex = 0;
            sortearCor();

            while (podeJogar == true)
            {
                podeJogar = false;
                if (sequenciaJogador[listaIndex] == "red")
                {
                    red_Click(sender, e);
                    pb = (PictureBox)sender;
                }
                atualCor = pb.ToString();
                sequenciaJogador.Add(atualCor);
                procurarBolinha(atualCor);

                if (sequenciaJogador[listaIndex] == sequenciaCores[listaIndex])
                {
                    pontos++;
                    pontosMarc.Text = "Pontos: " + pontos.ToString();
                    listaIndex++;
                    verificar();
                }

                else
                {
                    MessageBox.Show("Errooou!");
                    audios[4].Play();
                }
                
            }
        }

        private void verificar()
        {
            if (listaIndex == sequenciaCores.Count())
            {
                listaIndex = 0;
                sequenciaJogador.Clear();
                sortearCor();
            }

            else
            {
                podeJogar = true;
            }
        }

        private void opcao(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            switch (menu.Name)
            {
                case "iniciar":
                    //pontos = 0; pontosMarc.Text = "Pontos"; sequenciaCores.Clear(); sequenciaJogador.Clear();
                    //podeJogar = false; listaIndex = 0; sortearCor();
                    IniciarJogo();
                    break;
            }
        }

        
        private void green_Click(object sender, EventArgs e)
        {
            PictureBox pb = btnGreen;
        }

        public void blue_Click(object sender, EventArgs e)
        {
            PictureBox pb = btnBlue;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            PictureBox pb = btnYellow;
        }

        private void red_Click(object sender, EventArgs e)
        {
            PictureBox pb = btnRed;
            sequenciaJogador.Add("red");

        }


        /*
        private void vermelho_(object sender, EventArgs e)
        {
            
            PictureBox picVermelho = (PictureBox)sender;
            if (podeJogar)
            {
                podeJogar = false;
                atualCor = picVermelho.Tag.ToString();
                sequenciaJogador.Add(atualCor);
                procurarBolinha(atualCor);

                if (sequenciaJogador[listaIndex] == sequenciaCores[listaIndex])
                {

                }

                else
                {
                    MessageBox.Show("Errooou!");
                    audios[4].Play();
                }
                
            }
            
        }

        /*
        private void green_Click(object sender, EventArgs e)
        {
            
        }

        private void blue_Click(object sender, EventArgs e)
        {
            
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            
        }
        */


        //private void Jogar_Click(object sender, EventArgs e)
        //{
        //    sortearCor();
        //    pontos = 0;
        //    pontosMarc.Text = "Pontos: ";
        //    sequenciaJogador.Clear();
        //    sequenciaCores.Clear();
        //    podeJogar = false;
        //    listaIndex = 0;

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void botao_sobre_Click(object sender, EventArgs e)
        {
            string sobre = "Jogo Genius Colors desenvolvido por Daniel Muniz, Rafael Jordão, Nathalia Martins, Feliza Santos, Daniely, Nathalia Aparecida";
            MessageBox.Show(sobre);
        }

        private void Jogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void IniciarJogo()
        {
            pontos = 0;
            podeJogar = false;
            pontosMarc.Text = "Pontos";
            sequenciaCores.Clear();
            sequenciaJogador.Clear();
            listaIndex = 0;
            sortearCor();
        }

    }
}
