﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btFacil_Click(object sender, EventArgs e)
        {
            Jogo jogoFacil = new Jogo();
            jogoFacil.ShowDialog();
        }
    }
}
