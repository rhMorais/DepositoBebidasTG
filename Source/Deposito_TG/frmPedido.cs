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
    public partial class frmPedido : Form
    {
        public frmPedido()
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
                SqlDataAdapter da = new SqlDataAdapter("select p.idped, p.idobs, p.desconto, p.vltotal, a.nome, c.nome " +
                                "from pedido p inner join atendente a on p.idaten = a.idaten " +
                                "inner join cliente c on p.idcli = c.idcli " , Conexao.SqlCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvpedido.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            DgvDados();
        }
    }
}
