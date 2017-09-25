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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        private void limpar()
        {
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtpreco.Clear();
            cbovendedor.SelectedIndex = -1;           
            txtdescricao.Focus();                   
        }
        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from consultaProduto ", Conexao.SqlCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvproduto.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void carregarclientes()
        {
            //this.cbobairros.Items.Clear();
            string s = "SELECT idven, nome FROM vendedor";
            Conexao.Active(true);
            SqlCommand cmd = new SqlCommand(s, Conexao.SqlCnn);
            SqlDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["nome"].ToString(), Convert.ToInt32(r["idven"]));
            }
            this.cbovendedor.DataSource = new BindingSource(p, null);
            this.cbovendedor.DisplayMember = "key";
            this.cbovendedor.ValueMember = "value";
        }


        private void frmProduto_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarclientes();
        }

        private void dgvproduto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvproduto.RowCount > 0 && dgvproduto.SelectedRows.Count == 1)
            {
                int produtoCodigo = Convert.ToInt32(dgvproduto.SelectedRows[0].Cells[Codigo.Name].Value);
                string sql = "exec sp_consultaproduto " + produtoCodigo;
                try
                {
                    Conexao.Active(true);
                    SqlCommand cmd = new SqlCommand(sql, Conexao.SqlCnn);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtcodigo.Text = dr["idpro"].ToString();
                        txtdescricao.Text = dr["descricao"].ToString();
                        txtpreco.Text = dr["preco"].ToString();
                        cbovendedor.Text = dr["nome"].ToString();
                        cboempresa.Text = dr["empresa"].ToString();
                        tbcProduto.SelectedIndex = 1;
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

        private void tbcProduto_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcProduto.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
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
            string strIncluir = "INSERT INTO produto "
                                + "VALUES('" + txtdescricao.Text + "',"                                
                                + " '" + (txtpreco.Text).Replace(",", ".") + "', "
                                + Convert.ToInt32(this.cbovendedor.SelectedValue) + ")";

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
            string strAlterar = "UPDATE produto "
                             + "SET descricao = '" + txtdescricao.Text + "', "
                             + "preco = '" + (txtpreco.Text).Replace(",", ".") + "', "
                             + "idvendedor = " + Convert.ToInt32(this.cbovendedor.SelectedValue)
                             + " WHERE idpro = " + txtcodigo.Text;
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
            string strDelete = "DELETE FROM produto WHERE idpro = " + txtcodigo.Text;
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

        private void txtlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void cbovendedor_Leave(object sender, EventArgs e)
        {            
            string empresa = "Select empresa from vendedor where idven = "
                            + Convert.ToInt32(this.cbovendedor.SelectedValue);
            try
            {
                Conexao.Active(true);
                SqlCommand cmd = new SqlCommand(empresa, Conexao.SqlCnn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cboempresa.Text = dr["empresa"].ToString();
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }        
    }
}
