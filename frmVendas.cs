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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        void HabilitaCampos(bool status)
        {
            txtCodigo.Enabled = false;
            dtpData.Enabled = status;
            txtCliente.Enabled = status;
            cmbCliente.Enabled = status;
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnRemover.Enabled = status;

            if (status == false)
            {
                txtCodigo.Text = "";
                dtpData.Value = DateTime.Now.Date;
                op = 'S';
            }
            dgvVendas.DataSource = "";
            Camadas.BLL.Vendas bllVendas = new Camadas.BLL.Vendas();
            dgvVendas.DataSource = bllVendas.Select();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Clientes bllClientes = new Camadas.BLL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "codigo";
            cmbCliente.DataSource = bllClientes.Select();
            HabilitaCampos(false);
        }

        public char op { get; set; }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            op = 'I';
            txtCodigo.Text = "-1";
            dtpData.Value = DateTime.Now.Date;
            dtpData.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Vendas bllVendas = new Camadas.BLL.Vendas();
            Camadas.Model.Vendas venda = new Camadas.Model.Vendas();
            venda.codVenda = Convert.ToInt32(txtCodigo.Text);
            venda.data = Convert.ToDateTime(dtpData.Value.ToShortDateString());
            venda.cliente = Convert.ToInt32(txtCliente.Text);
            if (op == 'I')
                bllVendas.Insert(venda);
            else if (op == 'U')
                bllVendas.Update(venda);
            HabilitaCampos(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCodigo.Text) > 0)
            {
                HabilitaCampos(true);
                op = 'U';
                txtCliente.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCodigo.Text) > 0)
            {
                Camadas.BLL.Vendas bllVendas = new Camadas.BLL.Vendas();
                Camadas.Model.Vendas venda = new Camadas.Model.Vendas();
                venda.codVenda = Convert.ToInt32(txtCodigo.Text);
                bllVendas.Delete(venda);
                HabilitaCampos(false);
            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                int id = int.Parse(txtCodigo.Text);
                frmItensVenda frmIVenda = new frmItensVenda();
                frmIVenda.ShowDialog();

                dgvVendas.DataSource = "";
                Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
                dgvVendas.DataSource = bllItemVenda.SelectById(int.Parse(txtCodigo.Text));

            }
            else MessageBox.Show("Campo venda esta vazio....");
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Código Cliente Inexistente");
                throw;
            }
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvVendas_MouseClick(object sender, MouseEventArgs e)
        {
             try
            {
                txtCodigo.Text = dgvVendas.SelectedRows[0].Cells[0].Value.ToString();
                dtpData.Value = Convert.ToDateTime(dgvVendas.SelectedRows[0].Cells[1].Value);
                txtCliente.Text = dgvVendas.SelectedRows[0].Cells[2].ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(dgvVendas.SelectedRows[0].Cells[2].Value);
                btnRemover.Enabled = true;

                //dgvItensVenda.DataSource = "";
                //Camadas.BLL.ItemVenda bllItemVenda = new Camadas.BLL.ItemVenda();
                //dgvItensVenda.DataSource = bllItemVenda.SelectById(int.Parse(txtCodigo.Text)); 


            }
            catch (Exception)
             {
                 throw;
             }
        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = "" + cmbCliente.SelectedValue.ToString();
           
        }
    }
}
