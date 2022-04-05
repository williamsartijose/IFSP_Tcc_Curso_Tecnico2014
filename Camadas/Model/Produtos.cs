using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.Model
{
    public class Produtos   //mapear em memoria os produtos que estao no banco de dados
    {
        public int codigo { get; set; }  //atributos
        public string descricao { get; set; }
        public float valor { get; set; }
        public float quantidade { get; set; }
        public DateTime validade { get; set; }
    }
}
