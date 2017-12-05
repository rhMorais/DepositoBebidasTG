using System;
using System.Data;
using System.Data.SqlClient;

namespace Deposito_TG.Repositorio
{
    class Contexto : IDisposable
    {
        private readonly SqlConnection minhaConexao;

        public Contexto()
        {
            // string de conexão do notebook
            //minhaConexao = new SqlConnection(@"data source=PC-RAFAEL\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DepositoTG");

            //string de conexão do pc do trabalho
            minhaConexao = new SqlConnection(@"data source=RAFAELHENRIQUE-\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=BancoDepositoTG");
            minhaConexao.Open();
        }        

        public void Dispose()
        {
            if(minhaConexao.State == ConnectionState.Open)
            {
                minhaConexao.Close();
            }
        }

        public SqlCommand ExecutaProcedure(string procedureName)
        {
            return new SqlCommand
            {
                CommandText = procedureName,
                CommandType = CommandType.StoredProcedure,
                Connection = minhaConexao
            };
        }        
    }
}
