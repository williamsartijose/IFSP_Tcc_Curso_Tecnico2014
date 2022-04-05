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
    public partial class frmMenu : Form
    {
        private frmMenu frmMenu1;

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(frmMenu frmMenu1)
        {
            // TODO: Complete member initialization
            this.frmMenu1 = frmMenu1;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmCliente frm = new frmCliente();
            frm.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void emailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.gmail.com.br");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }

        private void facebookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Games");
        }

        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wmplayer.EXE");
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void navegadorWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com.br");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();// data 

            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();// hora
         
            
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.ShowDialog();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/pages/WSJ-Informatica/301925833329389?fref=ts");


        }

        private void evertonRochaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/the.everton.rocha");
        }

        private void williamSartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/william.Delonge.357284");
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new frmCliente().ShowDialog();












        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click_1(object sender, EventArgs e)
        {
        }

        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.Show();
        }

       

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRelatorio().ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new frmRelatorio().ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVen = new frmVendas();
            frmVen.Show();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new frmProdutos().ShowDialog();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmBuscar frmBus = new FrmBuscar();
            frmBus.Show();
        }

        private void caixaLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estoqueProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscar frm = new FrmBuscar();
            frm.Show();
        }

        private void caixaLivreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItensVenda fri = new frmItensVenda();
            fri.Show();
        }
        }
    }
