using System;
using System.Linq;
using System.Windows.Forms;
using Repositorio;
using Domain;

namespace Deposito_TG
{
    public partial class frmAtendente : Form
    {
        AtendenteRepositorio _repo = new AtendenteRepositorio();

        public frmAtendente()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcodigo.Focus();
        }
        private void DgvDados()
        {
            try { dgvatendente.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvatendente_DoubleClick(object sender, EventArgs e)
        {
            if (dgvatendente.RowCount > 0 && dgvatendente.SelectedRows.Count == 1)
            {                
                try
                {
                    int ateCodigo = Convert.ToInt32(dgvatendente.SelectedRows[0].Cells[Codigo.Name].Value);
                    var atendente = _repo.Selecionar(ateCodigo);
                    txtcodigo.Text = atendente.IdAten.ToString();
                    txtnome.Text = atendente.Nome;
                    tbcatendente.SelectedIndex = 1;
                    btnincluir.Enabled = false;
                    txtnome.Focus();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void tbcatendente_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcatendente.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmAtendente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl,
                    !e.Shift, true, true, true);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente(txtnome.Text);
            try
            {
                _repo.Salvar(atendente);
                MessageBox.Show("Atendente inserido com sucesso !!!");
                limpar();
                txtnome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente(Convert.ToInt32(txtcodigo.Text), txtnome.Text);
            try
            {
                _repo.Salvar(atendente);
                MessageBox.Show("Atendente editado com sucesso !!!");
                limpar();
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
                MessageBox.Show("Atendente excluído com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
