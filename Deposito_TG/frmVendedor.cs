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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }
        
        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * " +
                                "from vendedor", Conexao.SqlCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvvendedor.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            DgvDados();
        }
    }
}
