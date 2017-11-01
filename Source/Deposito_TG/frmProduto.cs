using Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class frmProduto : Form
    {
        ProdutoRepositorio _repo = new ProdutoRepositorio(); 

        public frmProduto()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtpreco.Clear();
            cmbvendedor.SelectedIndex = -1;
            txtcodigo.Focus();
        }
        private void DgvDados()
        {
            try { dgvprodutos.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void tbcprodutos_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcprodutos.SelectedIndex == 0)
                DgvDados();
        }

        private void dgvprodutos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int proCodigo = Convert.ToInt32(dgvprodutos.SelectedRows[0].Cells[Codigo.Name].Value);
                var produto = _repo.Selecionar(proCodigo);
                txtcodigo.Text = produto.IdPro.ToString();
                txtdescricao.Text = produto.Descricao;
                txtpreco.Text = produto.Preco.ToString();
                //Função que carrega combobox pegar!!
                tbcprodutos.SelectedIndex = 1;
                btnincluir.Enabled = false;
                txtdescricao.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

        private void btnvoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnnovovendedor_Click(object sender, EventArgs e)
        {
            Form f = new frmVendedor();
            f.ShowDialog();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
