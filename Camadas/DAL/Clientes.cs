using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Clientes> Select()
        {
            List<Model.Clientes> listaClientes = new List<Model.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Clientes cliente = new Model.Clientes();
                    cliente.codigo = Convert.ToInt32(reader[0].ToString());
                    cliente.nome = reader["nome"].ToString();
                    listaClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na Selecao de registros");
            }
            finally
            {
                conexao.Close();
            }
            return listaClientes;
        }

        public void Insert(Model.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values (@nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {

                Console.WriteLine("Deu erro na inserção de Clientes");
            }
            finally
            {
                conexao.Close();
            }


        }

        public void Update(Model.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome ";
            sql = sql + " where codigo=@cod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cod", cliente.codigo);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where codigo=@cod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cod", cliente.codigo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao de Cliente...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
