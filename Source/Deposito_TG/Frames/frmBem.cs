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
    public partial class frmBem : Form
    {
        BemAlugavelRepositorio _repo = new BemAlugavelRepositorio();

        public frmBem()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtnumpatrimonio.Clear();
            txtvlaluguel.Clear();
            txtdescricao.Focus();
        }

        private void DgvDados()
        {
            try { dgvbem.DataSource = _repo.Listar().ToList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmBem_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvbem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int bemCodigo = Convert.ToInt32(dgvbem.SelectedRows[0].Cells[Codigo.Name].Value);
                var bem = _repo.Selecionar(bemCodigo);
                txtcodigo.Text = bem.IdBem.ToString();
                txtdescricao.Text = bem.Descricao;
                txtnumpatrimonio.Text = bem.NumPatrimonio;
                tbcbem.SelectedIndex = 1;
                btnincluir.Enabled = false;
                txtdescricao.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tbcbem_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcbem.SelectedIndex == 0)
                DgvDados();
        }

        private void frmBem_KeyDown(object sender, KeyEventArgs e)
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
            limpar();
        }
    }
}
