using System;
using System.Linq;
using System.Windows.Forms;
using Repositorio;
using Domain;
using Services;

namespace Deposito_TG
{
    public partial class frmCliente : Form
    {
        private readonly ClienteRepositorio _repo = new ClienteRepositorio();
        private readonly ClienteService _service = new ClienteService();

        public frmCliente()
        {
            InitializeComponent();
            modoIncluir();
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
                PreencherCampos(_repo.Selecionar(cliCodigo));
                tbccliente.SelectedIndex = 1;
                modoEditar();
                txtnome.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            try
            {
                var response = _service.Salvar(GetDadosCampos());
                MessageBox.Show(response.Message);
                if (response.Status != 200)
                    return;
                Limpar();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var response = _service.Salvar(GetDadosCampos());
                MessageBox.Show(response.Message);
                if (response.Status != 200)
                    return;                
                Limpar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                var response = _service.Excluir(Convert.ToInt16(txtcodigo.Text));
                MessageBox.Show(response.Message);
                if (response.Status != 200)
                    return;
                Limpar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            txtnome.Focus();
            modoIncluir();
        }
        private void PreencherCampos(Cliente cliente)
        {
            txtcodigo.Text = cliente.IdCli.ToString();
            txtnome.Text = cliente.Nome;
            txtcpf.Text = cliente.Cpf;
            txtendereco.Text = cliente.Endereco;
            txtbairro.Text = cliente.Bairro;
            txtcidade.Text = cliente.Cidade;
            txttelefone.Text = cliente.Telefone;
            txtcelular.Text = cliente.Celular;
            txtemail.Text = cliente.Email;
        }
        private Cliente GetDadosCampos()
        {
            var codigo = txtcodigo.Text != "" ? Convert.ToInt16(txtcodigo.Text) : 0;
            return new Cliente(
                codigo,
                txtnome.Text, 
                txtcpf.Text, 
                txtendereco.Text, 
                txtbairro.Text,
                txtcidade.Text, 
                txttelefone.Text, 
                txtcelular.Text, 
                txtemail.Text
                );
        }
        private void modoIncluir()
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnincluir.Enabled = true;
        }
        private void modoEditar()
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnincluir.Enabled = false;
        }
    }
}
