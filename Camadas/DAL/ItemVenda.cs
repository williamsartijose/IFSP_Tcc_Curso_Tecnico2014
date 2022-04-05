using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Camadas.DAL;

namespace TCC.Camadas.DAL
{
    public class ItemVenda
    {
        private string strCon = Conexao.getConexao();

        public List<Model.ItemVenda> SelectById(int idVenda)
        {
            List<Model.ItemVenda> listaItensVendas = new List<Model.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from ItemVenda where codvenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVenda", idVenda);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemVenda itemVenda = new Model.ItemVenda();
                    itemVenda.itemVenda = Convert.ToInt32(reader["coditmvenda"].ToString());
                    itemVenda.venda = Convert.ToInt32(reader["codvenda"].ToString());
                    itemVenda.produto = Convert.ToInt32(reader["codpro"].ToString());
                    itemVenda.quantidade = Convert.ToSingle(reader["quantidade"].ToString());
                    itemVenda.preco = Convert.ToSingle(reader["valor"].ToString());
                    listaItensVendas.Add(itemVenda);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de itens de venda....");
            }
            finally
            {
                conexao.Close();
            }
            return listaItensVendas;
        }

        public List<Model.ItemVenda> Select()
        {
            List<Model.ItemVenda> listaItensVendas = new List<Model.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from ItemVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemVenda itemVenda = new Model.ItemVenda();
                    itemVenda.itemVenda = Convert.ToInt32(reader["coditmvenda"].ToString());
                    itemVenda.venda = Convert.ToInt32(reader["codvenda"].ToString());
                    itemVenda.produto = Convert.ToInt32(reader["codpro"].ToString());
                    itemVenda.quantidade = Convert.ToSingle(reader["quantidade"].ToString());
                    itemVenda.preco = Convert.ToSingle(reader["valor"].ToString());
                    listaItensVendas.Add(itemVenda);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de itens de venda....");
            }
            finally
            {
                conexao.Close();
            }
            return listaItensVendas;
        }

        public void Insert(Model.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Insert into ItemVenda values ( @venda, @produto,@quantidade, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@venda", itemVenda.venda);
            cmd.Parameters.AddWithValue("@produto", itemVenda.produto);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.quantidade);
            cmd.Parameters.AddWithValue("@valor", itemVenda.preco);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de itens de venda");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update ItemVenda set codpro=@produto, codvenda=@venda, ";
            sql += " quantidade=@quantidade, valor=@valor ";
            sql += " where coditmvenda=@coditmvenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@coditmvenda", itemVenda.itemVenda);
            cmd.Parameters.AddWithValue("@venda", itemVenda.venda);
            cmd.Parameters.AddWithValue("@produto", itemVenda.produto);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.quantidade);
            cmd.Parameters.AddWithValue("@valor", itemVenda.preco);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de itens de venda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from ItemVenda where coditmvenda=@coditmvenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@coditmvenda", itemVenda.itemVenda);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de itens de venda...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
