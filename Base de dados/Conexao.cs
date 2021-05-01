using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestao.Base_de_dados
{
    class Conexao
    {

        SqlConnection conexao = new SqlConnection();


        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Felipe\source\repos\SistemaGestao\SistemaGestao\BDSistemaGestao.mdf;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if (conexao.State ==System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }
        public void desconectar()
        {
            if (conexao.State==System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
       
    }
}
