using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.BLL
{
    public class Vendas
    {
        public List<Model.Vendas> Select()
        {
            DAL.Vendas dalVendas = new DAL.Vendas();
            return dalVendas.Select();
        }

        public void Insert(Model.Vendas venda)
        {
            DAL.Vendas dalVendas = new DAL.Vendas();
            dalVendas.Insert(venda);
        }

        public void Update(Model.Vendas venda)
        {
            DAL.Vendas dalVendas = new DAL.Vendas();
            dalVendas.Update(venda);
        }

        public void Delete(Model.Vendas venda)
        {
            DAL.Vendas dalVendas = new DAL.Vendas();
            dalVendas.Delete(venda);
        }

    }
}
