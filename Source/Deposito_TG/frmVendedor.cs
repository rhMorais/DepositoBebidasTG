using Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Deposito_TG
{
    public partial class frmVendedor : Form
    {
        VendedorRepositorio _repo = new VendedorRepositorio();

        public frmVendedor()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcelular.Clear();
            txttelefone.Clear();
            txtempresa.Clear();
            txtcodigo.Focus();
        }
        private void DgvDados()
        {
            try { dgvvendedores.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvvendedores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int venCodigo = Convert.ToInt32(dgvvendedores.SelectedRows[0].Cells[Codigo.Name].Value);
                var vendedor = _repo.Selecionar(venCodigo);
                txtcodigo.Text = vendedor.IdVen.ToString();
                txtnome.Text = vendedor.Nome;
                txtcelular.Text = vendedor.Celular;
                txttelefone.Text = vendedor.Telefone;
                txtempresa.Text = vendedor.Empresa;
                tbcvendedores.SelectedIndex = 1;
                btnincluir.Enabled = false;
                txtnome.Focus();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tbcvendedores_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcvendedores.SelectedIndex == 0)
                DgvDados();
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

        }

        private void btngravar_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
