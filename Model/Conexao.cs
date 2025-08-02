using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Conexao
    {
        private static string _Conexao = $"Data Source={Environment.UserDomainName};" +
            $"Initial Catalog=sysvendaDB;Integrated Security=true";
        private static string Mensagem { get; set; }
        public static string TestarConexao()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GetConexaoString()))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                        Mensagem = "Connected Successfuly";
                    else
                        Mensagem = "Error, the corrent ConnectionString is wrong!";
                }
            }
            catch (Exception ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }
        public static string GetConexaoString()
        {
            return _Conexao;
        }
    }
}
