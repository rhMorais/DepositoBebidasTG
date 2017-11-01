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
    public partial class frmCliente : Form
    {
        ClienteRepositorio _repo = new ClienteRepositorio();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcpf.Clear();
            txtendereco.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtemail.Clear();
            txtcodigo.Focus();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            try { dgvcliente.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void tbccliente_Selected(object sender, TabControlEventArgs e)
        {
            if (tbccliente.SelectedIndex == 0)
                DgvDados();
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void dgvcliente_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int cliCodigo = Convert.ToInt32(dgvcliente.SelectedRows[0].Cells[Codigo.Name].Value);
                var cliente = _repo.Selecionar(cliCodigo);
                txtcodigo.Text = cliente.IdCli.ToString();
                txtnome.Text = cliente.Nome;
                txtcpf.Text = cliente.Cpf;
                txtendereco.Text = cliente.Endereco;
                txtbairro.Text = cliente.Bairro;
                txtcidade.Text = cliente.Cidade;
                txttelefone.Text = cliente.Telefone;
                txtcelular.Text = cliente.Celular;
                txtemail.Text = cliente.Email;
                tbccliente.SelectedIndex = 1;
                btnincluir.Enabled = false;
                txtnome.Focus();
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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
