using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TCC.Camadas.DAL
{
    public class Produtos
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Produtos> SelectByCod(int codigo)
        {
            List<Model.Produtos> listaProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos where codigo=@cod";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cod", codigo);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produto = new Model.Produtos();
                    produto.codigo = Convert.ToInt32(reader[0].ToString());
                    produto.descricao = reader["descricao"].ToString();
                    produto.quantidade = Convert.ToSingle(reader["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    produto.validade = Convert.ToDateTime(reader["validade"].ToString());
                    listaProdutos.Add(produto);
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
            return listaProdutos;
        }

        public List<Model.Produtos> SelectByNome(string nome)
        {
            List<Model.Produtos> listaProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos where (descricao like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produto = new Model.Produtos();
                    produto.codigo = Convert.ToInt32(reader[0].ToString());
                    produto.descricao = reader["descricao"].ToString();
                    produto.quantidade = Convert.ToSingle(reader["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    produto.validade = Convert.ToDateTime(reader["validade"].ToString());
                    listaProdutos.Add(produto);
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
            return listaProdutos;
        }

        public List<Model.Produtos> Select()
        {
            List<Model.Produtos> listaProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produto = new Model.Produtos();
                    produto.codigo = Convert.ToInt32(reader[0].ToString());
                    produto.descricao = reader["descricao"].ToString();
                    produto.quantidade = Convert.ToSingle(reader["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    produto.validade = Convert.ToDateTime(reader["validade"].ToString());
                    listaProdutos.Add(produto);
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
            return listaProdutos;
        }

        public void Insert(Model.Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produtos values (@desc, @valor,@qtde, @validade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc", produto.descricao);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@qtde", produto.quantidade);
            cmd.Parameters.AddWithValue("@validade", produto.validade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {

                Console.WriteLine("Deu erro na inserção de Produtos");
            }
            finally
            {
                conexao.Close();
            }


        }

        public void Update(Model.Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produtos set descricao=@desc, valor=@valor, ";
            sql = sql + " quantidade=@qtde, validade=@validade ";
            sql = sql + " where codigo=@cod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cod", produto.codigo);
            cmd.Parameters.AddWithValue("@desc", produto.descricao);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@qtde", produto.quantidade);
            cmd.Parameters.AddWithValue("@validade", produto.validade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de Produtos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produtos where codigo=@cod;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cod", produto.codigo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao de Produtos...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
