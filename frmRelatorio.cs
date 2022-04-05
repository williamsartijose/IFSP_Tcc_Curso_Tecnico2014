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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmFormularios_Load(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new relProduto().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new relVendas().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new relClientes().ShowDialog();
        }
    }
}
