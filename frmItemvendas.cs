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
    public partial class frmItensVenda : Form
    {
        private char op = 'S';
        private int idVenda = -1;
        private Camadas.Model.Produtos produtos;

        public frmItensVenda(int id)
        {
            idVenda = id;
            InitializeComponent();
        }
        public frmItensVenda()
        {
            InitializeComponent();
        }

        void PesquisaProduto()
        {
            Camadas.BLL.Produtos bllProduto = new Camadas.BLL.Produtos();
            List<Camadas.Model.Produtos> listaProd = new List<Camadas.Model.Produtos>();
            listaProd = bllProduto.SelectByCod(int.Parse(txtPro.Text));
            produtos = listaProd.First();
        }
        private void recuperaValorProduto(){

            List<Camadas.Model.Produtos> listaProduto = new List<Camadas.Model.Produtos>();
            Camadas.BLL.Produtos bllProdutos = new Camadas.BLL.Produtos();
           int codigo = Convert .ToInt32(txtPro.Text);
            if(codigo > -0)
            {
                listaProduto = bllProdutos.SelectByCod(codigo);
                if (listaProduto!=null)//listaProduto[0]
                    txtValor.Text = listaProduto[0].valor.ToString();
                else txtValor.Text  = "0";

                
            }

    
    }
        private void calculaTotal()//calcular os valores 
        {
            float qt = 0, valor = 0, total;
            if(txtValor.Text != string.Empty)
                valor = Convert.ToSingle(txtValor.Text);
            if (txtQuan.Text != "")
                qt = Convert.ToSingle(txtQuan.Text);
            total = qt * valor;
            lblTotal.Text = total.ToString();

        }


        void HabilitaCampos(bool status)
        {
            txtPro.Enabled = status;
            txtQuan.Enabled = status;
            txtValor.Enabled = status;
            cmbProduto.Enabled = status;
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnRemover.Enabled = status;

            if (status == false)
            {
                txtPro.Text = "";
                txtQuan.Text = "";
                txtValor.Text = "";

                op = 'S';
            }
            dtgvItensVenda.DataSource = "";
            Camadas.BLL.ItemVenda bllItemVendas = new Camadas.BLL.ItemVenda();
            dtgvItensVenda.DataSource = bllItemVendas.SelectById(idVenda);
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            Opacity = 'I';
            txtItemvenda.Text = "-1";
            txtVenda.Text = idVenda.ToString();
            txtPro.Text = cmbProduto.SelectedValue.ToString();
            txtPro.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtItemvenda.Text) > 0)
            {
                HabilitaCampos(true);
                op = 'U';
                txtPro.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemVenda bllItemVendas = new Camadas.BLL.ItemVenda();
            Camadas.Model.ItemVenda itemVenda = new Camadas.Model.ItemVenda();
            itemVenda.itemVenda = Convert.ToInt32(txtItemvenda.Text);
            itemVenda.venda = Convert.ToInt32(txtVenda.Text);
            itemVenda.produto = Convert.ToInt32(txtPro.Text);
            itemVenda.quantidade = Convert.ToSingle(txtQuan.Text);
            itemVenda.valor = Convert.ToSingle(txtValor.Text);
            if (op == 'I')
                bllItemVendas.Insert(itemVenda);
            else if (op == 'U')
                bllItemVendas.Update(itemVenda);
            HabilitaCampos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtItemvenda.Text) > 0)
            {
                Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
                Camadas.Model.ItemVenda itemVenda = new Camadas.Model.ItemVenda();
                bllItemVenda.Delete(itemVenda);
                HabilitaCampos(false);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtItemvenda.Text = dtgvItensVenda.SelectedRows[0].Cells[0].Value.ToString();
                txtVenda.Text = dtgvItensVenda.SelectedRows[0].Cells[1].Value.ToString();
                txtPro.Text = dtgvItensVenda.SelectedRows[0].Cells[2].Value.ToString();
                txtQuan.Text = dtgvItensVenda.SelectedRows[0].Cells[3].Value.ToString();
                txtValor.Text = dtgvItensVenda.SelectedRows[0].Cells[3].Value.ToString();
                float valor = Convert.ToSingle(txtQuan.Text) * Convert.ToSingle(txtValor.Text);
                txtValor.Text = valor.ToString();
                btnRemover.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

      
        private void frmItensVenda_Load(object sender, EventArgs e)
        {
            List<Camadas.Model.Produtos> listaProduto = new List<Camadas.Model.Produtos>(); 
            Camadas.BLL.Produtos bllProduto = new Camadas.BLL.Produtos();
            listaProduto = bllProduto.Select();
            cmbProduto.DisplayMember  = "descricao"; //MOSTRAR NA COMBO BOX 
            cmbProduto.ValueMember = "codigo"; //campo membro que relaciona com codigo
            cmbProduto.DataSource = listaProduto; //carregar lista do banco 

            opcao = 'x';
            Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
            dtgvItensVenda.DataSource = bllItemVenda.SelectById(idVenda);
            HabilitaCampos(false);

        }



        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            txtPro.Text = cmbProduto.SelectedValue.ToString();
            PesquisaProduto();
            txtValor.Text = produtos.valor.ToString();//valor do value member
            recuperaValorProduto();
        }

        private void txtPro_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbProduto.SelectedValue = Convert.ToInt32(txtPro.Text);
                recuperaValorProduto();
            }
            catch
            {
                MessageBox.Show("codigo produto  inexistente;;;");
                txtPro.Focus();//erro no cmbproduto
            }

            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuan_Leave(object sender, EventArgs e)
        {
            calculaTotal();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            calculaTotal();
        }




        public char opcao { get; set; }

        private void txtPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
