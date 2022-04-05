using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.BLL
{
    public class Produtos
    {
        public List<Model.Produtos> Select()
        {
            DAL.Produtos dalProd = new DAL.Produtos();
            return dalProd.Select();
        }

        public List<Model.Produtos> SelectByCod(int codigo)
        {
            DAL.Produtos dalProd = new DAL.Produtos();
            return dalProd.SelectByCod(codigo);
        }

        public List<Model.Produtos> SelectByNome(string nome)
        {
            DAL.Produtos dalProd = new DAL.Produtos();
            return dalProd.SelectByNome(nome);
        }

        public void Insert(Model.Produtos produto)
        {
            DAL.Produtos dalProd = new DAL.Produtos();
            dalProd.Insert(produto);
        }

        public void Update(Model.Produtos produto)
        {
            DAL.Produtos dalProd = new DAL.Produtos();
            dalProd.Update(produto);
        }

        public void Delete(Model.Produtos produto)
        {
            DAL.Produtos dalProd = new DAL.Produtos();
            dalProd.Delete(produto);
        }

        internal List<Model.Produtos> selesctbycodigo(string p)
        {
            throw new NotImplementedException();
        }

        internal List<Model.Produtos> selesctbydescricao(string p)
        {
            throw new NotImplementedException();
        }

        internal List<Model.Produtos> select()
        {
            throw new NotImplementedException();
        }
    }
}
