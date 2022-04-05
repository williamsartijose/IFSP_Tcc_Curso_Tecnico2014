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
    public partial class frmProdutos : Form
    {
        private char opcao = 'S';
        public List<Camadas.Model.Produtos> lstPro { get; set; }
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
             Camadas.DAL.Produtos dalProd = new Camadas.DAL.Produtos();
            dgvProdutos.DataSource = dalProd.Select();
            Habilita(false);
        }
         private void Habilita(bool status)
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = status;
            txtQuan.Enabled = status;
            txtValor.Enabled = status;
            txtValidade.Enabled = status;
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            if (status == false)
            {
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                txtQuan.Text = "";
                txtValidade.Text = "";
                txtValor.Text = "";
                opcao = 'S';
            }

            Camadas.BLL.Produtos bllProd = new Camadas.BLL.Produtos();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar frmBu = new FrmBuscar();
            frmBu.ShowDialog();
          
          
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Habilita(true);
            txtCodigo.Text = "-1";
            txtDescricao.Text = "";
            txtQuan.Text = "";
            txtValidade.Text = "";
            txtValor.Text = "";
            opcao = 'I';
            txtDescricao.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                Habilita(true);
                opcao = 'E';
                txtDescricao.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            {
                if (txtDescricao.Text != string.Empty)
                {
                    Camadas.Model.Produtos produto = new Camadas.Model.Produtos();
                    produto.codigo = Convert.ToInt32(txtCodigo.Text);
                    produto.descricao = txtDescricao.Text;
                    produto.quantidade = Convert.ToSingle(txtQuan.Text);
                    produto.valor = Convert.ToSingle(txtValor.Text);
                    produto.validade = Convert.ToDateTime(txtValidade.Text);
                    DialogResult resp;
                    resp = MessageBox.Show("Confirma Inserção de Produtos", "Inserir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    Camadas.BLL.Produtos bllProd = new Camadas.BLL.Produtos();
                    if (resp == DialogResult.Yes)
                    {
                        if (opcao == 'I')
                            bllProd.Insert(produto);
                        else if (opcao == 'E')
                            bllProd.Update(produto);
                    }
                    Habilita(false);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilita(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
             if (txtCodigo.Text != "")
            {
                Camadas.DAL.Produtos dalProd = new Camadas.DAL.Produtos();
                Camadas.Model.Produtos produto = new Camadas.Model.Produtos();
                //popular-preencher o objeto produto com dados do formulario
                produto.codigo = Convert.ToInt32(txtCodigo.Text);

                DialogResult resp;
                resp = MessageBox.Show("Confirma Remoção", "Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 
                                        MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    //insere no banco de dados
                    dalProd.Delete(produto);
                }
            }
            else MessageBox.Show("Não há registros Selecionados", "Remover Produtos", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Habilita(false); 
        }
        }
    }

