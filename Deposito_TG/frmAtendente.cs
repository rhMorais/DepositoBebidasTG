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
    public partial class frmAtendente : Form
    {
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
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from atendente", Conexao.SqlCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvatendente.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvatendente_DoubleClick(object sender, EventArgs e)
        {
            if (dgvatendente.RowCount > 0 && dgvatendente.SelectedRows.Count == 1)
            {
                int ateCodigo = Convert.ToInt32(dgvatendente.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "SELECT * FROM atendente "
                           + "WHERE idaten = " + ateCodigo;
                try
                {
                    Conexao.Active(true);
                    SqlCommand cmd = new SqlCommand(sql, Conexao.SqlCnn);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtcodigo.Text = dr["idaten"].ToString();
                        txtnome.Text = dr["nome"].ToString();
                        tbcatendente.SelectedIndex = 1;
                        txtnome.Focus();
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
            string strIncluir = "INSERT INTO atendente"
                                + " VALUES('" + txtnome.Text + "')";
            Conexao.Active(true);
            try
            {
                SqlCommand cmd = new SqlCommand(strIncluir, Conexao.SqlCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtnome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE atendente "
                             + " SET nome = '" + txtnome.Text
                             + "' WHERE idaten = " + txtcodigo.Text;
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
            string strDelete = "DELETE FROM atendente WHERE idaten = " + txtcodigo.Text;
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
