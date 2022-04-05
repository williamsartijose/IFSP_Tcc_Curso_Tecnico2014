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
    public partial class FrmBuscar : Form
    {
        Camadas.BLL.Produtos bllProduto = new Camadas.BLL.Produtos();
        List<Camadas.Model.Produtos> listaProdutos = new List<Camadas.Model.Produtos>();
        frmProdutos frmProb = new frmProdutos();

        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            rdbTodos.Checked = true; //rbd todos esta marcado 

        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblBuc.Visible = false;
            txtBusc.Visible = false;
            btnBusc.Visible = false;
            listaProdutos = bllProduto.select();
            dtgvBusc.DataSource = listaProdutos;
        }

        private void rdbCod_CheckedChanged(object sender, EventArgs e)
        {
            lblBuc.Text = "Passe o codigo :";
            txtBusc.Text = "";
            lblBuc.Visible = true;
            txtBusc.Visible = true;
            btnBusc.Visible = true;
            txtBusc.Focus();
        }

        private void btnBusc_Click(object sender, EventArgs e)
        {
            FrmBuscar formbusc = new FrmBuscar();
            formbusc.ShowDialog();
               
        }

       
    }
}
