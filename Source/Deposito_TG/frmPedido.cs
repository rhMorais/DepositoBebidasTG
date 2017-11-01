using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Repositorio;

namespace Deposito_TG
{
    public partial class frmPedido : Form
    {
        PedidoRepositorio _repo = new PedidoRepositorio();

        public frmPedido()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtcodigopedido.Clear();
            txtobservacao.Clear();
            txtcodigoproduto.Clear();
            txtquantidadeproduto.Clear();
            txtvaloruniproduto.Clear();
            txtvalortotal.Clear();
            txtdesconto.Clear();
            txttotalproduto.Clear();
            cboatendente.SelectedIndex = -1;
            cboproduto.SelectedIndex = -1;
            cbocliente.SelectedIndex = -1;
            txtcodigopedido.Focus();
        }

        private void DgvDados()
        {
            try { dgvpedido.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbcpedido_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void dgvpedido_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnincluir_Click(object sender, EventArgs e)
        {

        }

        private void btngravar_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnnovocliente_Click(object sender, EventArgs e)
        {
            Form f = new frmCliente();
            f.Show();
        }
    }
}
