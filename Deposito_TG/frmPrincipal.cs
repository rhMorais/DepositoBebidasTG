﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)//completo
            //mais simples          
            {
                this.Close(); //fecha o formulário atual          
            }
        }

        private void consultaAtendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmAtendente();
            f.ShowDialog();
        }
        private void manutençãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmCliente();
            f.ShowDialog();
        }
        private void manutençãoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmPedido();
            f.ShowDialog();
        }
        private void manutençãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmProduto();
            f.ShowDialog();
        }
        private void manutençãoDeBensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmBem();
            f.ShowDialog();
        }

        private void manutençãoDeVendedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form f = new frmVendedor();
            f.ShowDialog();
        }
    }
}
