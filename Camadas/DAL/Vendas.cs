using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.DAL
{
    public class Vendas
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Vendas> Select()
        {
            List<Model.Vendas> listaVendas = new List<Model.Vendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Venda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Vendas venda = new Model.Vendas();
                    venda.codVenda = Convert.ToInt32(reader["codvenda"].ToString());
                    venda.data = Convert.ToDateTime(reader["data"].ToString());
                    venda.cliente = Convert.ToInt32(reader["cliente"].ToString());
                    listaVendas.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na seleção de Vendas....");
            }
            finally
            {
                conexao.Close();
            }
            return listaVendas;
        }

        public void Insert(Model.Vendas venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Insert into Venda (data, cliente) values (@data, @cliente);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", venda.data);
            cmd.Parameters.AddWithValue("@cliente", venda.cliente);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Vendas");
                
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Vendas venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Venda set data=@data, cliente=@cliente ";
            sql += " where codvenda=@codvenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codvenda", venda.codVenda);
            cmd.Parameters.AddWithValue("@data", venda.data);
            cmd.Parameters.AddWithValue("@cliente", venda.cliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Vendas venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Venda where codvenda=@codvenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codvenda", venda.codVenda);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
