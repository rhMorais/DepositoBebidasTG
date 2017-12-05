using Domain;
using Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class FrmVendedor : Form
    {
        private readonly VendedorRepositorio _repo = new VendedorRepositorio();
        bool _backProdutos;

        public FrmVendedor()
        {
            InitializeComponent();
            ModoIncluir();
        }
        public FrmVendedor(bool aba)
        {
            InitializeComponent();
            _backProdutos = true;
            tbcvendedores.SelectedIndex = 1;
            ModoIncluir();
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
                var venCodigo = Convert.ToInt32(dgvvendedores.SelectedRows[0].Cells[Codigo.Name].Value);
                PreencherCampos(_repo.Selecionar(venCodigo));
                tbcvendedores.SelectedIndex = 1;
                ModoEditar();
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
                SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {            
            try
            {
                _repo.Salvar(GetVendedor());
                MessageBox.Show("Vendedor inserido com sucesso!");
                Limpar();
                txtnome.Focus();
                if (_backProdutos) { new frmProduto().ShowDialog(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.Salvar(GetVendedor());
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

        private Vendedor GetVendedor()
        {
            var codigo = txtcodigo.Text != "" ? Convert.ToInt16(txtcodigo.Text) : 0;
            return new Vendedor
            (
                codigo,
                txtnome.Text, 
                msktelefone.Text,
                mskcelular.Text, 
                txtempresa.Text
            );
        }

        private void PreencherCampos(Vendedor vendedor)
        {
            txtcodigo.Text = vendedor.IdVen.ToString();
            txtnome.Text = vendedor.Nome;
            mskcelular.Text = vendedor.Celular;
            msktelefone.Text = vendedor.Telefone;
            txtempresa.Text = vendedor.Empresa;
        }

        private void ModoIncluir()
        {
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            btnincluir.Enabled = true;
        }

        private void ModoEditar()
        {
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;
            btnincluir.Enabled = false;
        }
    }
}
