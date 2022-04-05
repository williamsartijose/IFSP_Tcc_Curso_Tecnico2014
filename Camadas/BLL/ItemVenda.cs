using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.BLL
{
    public class ItemVenda
    {
        public List<Model.ItemVenda> SelectById(int idVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            return dalItemVendas.SelectById(idVenda);
        }

        public List<Model.ItemVenda> Select()
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            return dalItemVendas.Select();
        }

        public void Insert(Model.ItemVenda itemVenda)
        {
            //regras de negocio  de baixar estoque

            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();

            BLL.Produtos bllProd = new BLL.Produtos();
            Model.Produtos produto = new Model.Produtos();
            List<Model.Produtos> listaProduto = bllProd.SelectByCod(itemVenda.produto);
            produto = listaProduto[0];
            produto.quantidade = produto.quantidade - itemVenda.quantidade;
            bllProd.Update(produto);
            dalItemVendas.Insert(itemVenda);
        }

        public void Update(Model.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            dalItemVendas.Update(itemVenda);
        }

        public void Delete(Model.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            dalItemVendas.Delete(itemVenda);
        }
    }
}
