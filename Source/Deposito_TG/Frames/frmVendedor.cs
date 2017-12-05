using Domain;
using Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class frmVendedor : Form
    {
        VendedorRepositorio _repo = new VendedorRepositorio();
        bool backProdutos = false;
        public frmVendedor()
        {
            InitializeComponent();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
        }
        public frmVendedor(bool aba)
        {
            InitializeComponent();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            backProdutos = true;
            tbcvendedores.SelectedIndex = 1;
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            mskcelular.Clear();
            msktelefone.Clear();
            txtempresa.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = true;
            txtnome.Focus();
        }
        private void DgvDados()
        {
            try { dgvvendedores.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void frmVendedor_Load(object sender, EventArgs e)
        {
            DgvDados();
            txtnome.Focus();
        }
        private void dgvvendedores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int venCodigo = Convert.ToInt32(dgvvendedores.SelectedRows[0].Cells[Codigo.Name].Value);
                var vendedor = _repo.Selecionar(venCodigo);
                txtcodigo.Text = vendedor.IdVen.ToString();
                txtnome.Text = vendedor.Nome;
                mskcelular.Text = vendedor.Celular;
                msktelefone.Text = vendedor.Telefone;
                txtempresa.Text = vendedor.Empresa;
                tbcvendedores.SelectedIndex = 1;
                btnincluir.Enabled = false;
                btnexcluir.Enabled = true;
                btngravar.Enabled = true;
                txtnome.Focus();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void tbcvendedores_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcvendedores.SelectedIndex == 0)
            {
                DgvDados();
                return;
            }
            txtnome.Focus();
        }
        private void frmVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnincluir_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor(
                txtnome.Text, msktelefone.Text,
                mskcelular.Text, txtempresa.Text);
            try
            {
                _repo.Salvar(vendedor);
                MessageBox.Show("Vendedor inserido com sucesso!");
                Limpar();
                txtnome.Focus();
                if (backProdutos) { new frmProduto().ShowDialog(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btngravar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor(Convert.ToInt32(txtcodigo.Text), 
                txtnome.Text, msktelefone.Text,
                mskcelular.Text, txtempresa.Text);
            try
            {
                _repo.Salvar(vendedor);
                MessageBox.Show("Vendedor editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Excluir(Convert.ToInt32(txtcodigo.Text));
                MessageBox.Show("Vendedor excluído com sucesso!");
                Limpar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
