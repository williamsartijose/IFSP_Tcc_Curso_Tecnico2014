using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCCDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.tCCDataSet.Cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tCCDataSet);
            MessageBox.Show("Cliete Salvo Com Sucesso", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);//// buton salvar

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(); //// botao cancelar
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja  exluir o registro ??", "pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tCCDataSet);///botao exluir
            }
            else
            {
                this.clienteTableAdapter.Fill(this.tCCDataSet.Cliente);// preenche e salava no bancoo
            }
        }

        private void clienteDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByCliente(tCCDataSet.Cliente, textBox2.Text);/// connectando com data set 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.buscacep.correios.com.br/");



        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tCCDataSet);
            MessageBox.Show("Cliete Salvo Com Sucesso", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);//// buton salvar
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();//CANCELAR
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (Convert.ToInt32(codigoTextBox.Text) > 0)
                {

                    
                }
                else
                {
                    MessageBox.Show("salve primeiro os dados para depois inserir imagem", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            {
                
                
                {
                    MessageBox.Show("salve primeiro os dados para depois inserir imagem", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
                
                {
                    MessageBox.Show("salve primeiro os dados para depois inserir imagem", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

