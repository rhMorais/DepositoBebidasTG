using System;
using System.Linq;
using System.Windows.Forms;
using Repositorio;

namespace Deposito_TG
{
    public partial class frmPedido : Form
    {
        PedidoRepositorio _repo = new PedidoRepositorio();

        public frmPedido() { InitializeComponent(); }

        public frmPedido(bool aba)
        {
            InitializeComponent();
            if (aba) tbcpedido.SelectedIndex = 1;
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

        private void cboproduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
