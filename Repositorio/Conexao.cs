using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deposito_TG
{
    public class Conexao
    {
        static SqlConnection sqlCnn;
        static SqlCommandBuilder sqlCmm = new SqlCommandBuilder();

        public static SqlConnection SqlCnn{
            get { return sqlCnn; }
        }

        public static SqlCommandBuilder SqlCmm{
            get { return sqlCmm; }
        }

        public static bool Active (bool bActive){
            if (bActive){
                string _conn;

                _conn = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BancoDeposito;Data Source=PC-RAFAEL\\SQLEXPRESS";

                sqlCnn = new SqlConnection(_conn);
                try{
                SqlCnn.Open();
                return true;
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else {
                SqlCnn.Close();
                return false;
            }
        }
    }
}
