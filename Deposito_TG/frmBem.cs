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

namespace Deposito_TG
{
    public partial class frmBem : Form
    {
        public frmBem()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtpatrimonio.Clear();
            txtvaloraluguel.Clear();
            txtdescricao.Focus();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from bemalugavel", Conexao.SqlCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvbem.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmBem_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvbem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvbem.RowCount > 0 && dgvbem.SelectedRows.Count == 1)
            {
                int bemCodigo = Convert.ToInt32(dgvbem.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "SELECT * FROM bemalugavel "
                           + "WHERE idbem = " + bemCodigo;
                try
                {
                    Conexao.Active(true);
                    SqlCommand cmd = new SqlCommand(sql, Conexao.SqlCnn);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtcodigo.Text = dr["idbem"].ToString();
                        txtdescricao.Text = dr["descricao"].ToString();
                        txtpatrimonio.Text = dr["numpatrimonio"].ToString();
                        txtvaloraluguel.Text = dr["vlaluguel"].ToString();                        
                        tbcbem.SelectedIndex = 1;
                        txtdescricao.Focus();
                    }
                }
                finally
                {
                    Conexao.Active(false);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void tbcbem_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcbem.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmBem_KeyDown(object sender, KeyEventArgs e)
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
            string strIncluir = "INSERT INTO bemalugavel"
                                + " VALUES('" + txtdescricao.Text + "',"
                                + " '" + txtpatrimonio.Text + "',"
                                + " '" + (txtvaloraluguel.Text).Replace(",", ".") + "')";
            Conexao.Active(true);
            try
            {
                SqlCommand cmd = new SqlCommand(strIncluir, Conexao.SqlCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtdescricao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE bemalugavel "
                             + " SET descricao = '" + txtdescricao.Text + "', "
                             + "numpatrimonio = '" + txtpatrimonio.Text + "', "
                             + "vlaluguel = '" + (txtvaloraluguel.Text).Replace(",", ".") + "' "
                             + "WHERE idbem = " + txtcodigo.Text;
            Conexao.Active(true);
            try
            {
                SqlCommand cmd = new SqlCommand(strAlterar, Conexao.SqlCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM bemalugavel WHERE idbem = " + txtcodigo.Text;
            Conexao.Active(true);
            try
            {
                SqlCommand cmd = new SqlCommand(strDelete, Conexao.SqlCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
