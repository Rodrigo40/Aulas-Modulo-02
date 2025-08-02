using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using Model;

namespace ControllerV
{
    public class UserController
    {
        private string Mensagem { get; set; }
        public string Cadastrar(UserModel user)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = con.CreateCommand();
            try
            {
                con.ConnectionString = Conexao.GetConexaoString();
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = "sp_CadastrarUser";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter SprNome = new SqlParameter();
                SprNome.ParameterName = "@nome";
                SprNome.Value = user.Nome;
                SprNome.DbType = DbType.String;
                SprNome.Size = 50;

                SqlParameter SprEmail = new SqlParameter();
                SprEmail.ParameterName = "@email";
                SprEmail.Value = user.Email;
                SprEmail.DbType = DbType.String;
                SprEmail.Size = 100;

                SqlParameter SprPassword = new SqlParameter();
                SprPassword.ParameterName = "@password";
                SprPassword.Value = user.Password;
                SprPassword.DbType = DbType.String;
                SprPassword.Size = 50;

                cmd.Parameters.Add(SprNome);
                cmd.Parameters.Add(SprEmail);
                cmd.Parameters.Add(SprPassword);

                if (cmd.ExecuteNonQuery() == 1)
                    Mensagem = $"Usuario {user.Nome}, cadastrado com sucesso!";
                else
                    Mensagem = $"Ups,Erro ao cadastrar o usuario,\nverifique os dados e tente novamente!";

            }
            catch (Exception ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }
        public UserModel Login(UserModel user)
        {
            UserModel model = new UserModel();
            using (SqlConnection connection = new SqlConnection(Conexao.GetConexaoString()))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserModel u = new UserModel(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetDateTime(4),
                                reader.GetDateTime(5)
                            );
                            model = u;
                        }
                    }
                }
            }
            return model;
        }
        public void VerificaUsers()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            SqlConnection con2 = new SqlConnection();
            SqlCommand cmd2 = new SqlCommand();

            try
            {
                con.ConnectionString = Conexao.GetConexaoString();
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = "sp_GetUsers";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();

                    con2.ConnectionString = Conexao.GetConexaoString();
                    con2.Open();

                    cmd2.Connection = con;
                    cmd2.CommandText = "sp_DifinirUserPadrao";
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                con2.Close();
                cmd.Dispose();
                cmd2.Dispose();
            }
        }
        public Task<DataTable> GetUsers()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                con.ConnectionString = Conexao.GetConexaoString();
                con.Open();

                cmd.Connection = con;
                cmd.CommandText= "sp_GetUsers";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
                con.Close();
                cmd.Dispose();
            }
            return Task.FromResult(dt);
        }
    }
}
