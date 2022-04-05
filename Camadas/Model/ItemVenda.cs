using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Camadas.Model
{
    public class ItemVenda
    {

        public int itemVenda { get; set; }
        public int venda { get; set; }
        public int produto { get; set; }
        public float quantidade { get; set; }
        public float preco { get; set; }

        public float valor { get; set; }
    }
}
