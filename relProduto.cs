using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class relProduto : Form
    {
        public relProduto()
        {
            InitializeComponent();
        }

        private void relProduto_Load(object sender, EventArgs e)
        {
            
          
            
            
            // TODO: This line of code loads data into the 'TCCDataSet.Produtos' table. You can move, or remove it, as needed.
            this.ProdutosTableAdapter.Fill(this.TCCDataSet.Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
