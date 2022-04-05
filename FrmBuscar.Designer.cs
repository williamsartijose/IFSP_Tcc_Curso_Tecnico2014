namespace TCC
{
    partial class FrmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grBus = new System.Windows.Forms.GroupBox();
            this.rdbDescr = new System.Windows.Forms.RadioButton();
            this.rdbCod = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.lblBuc = new System.Windows.Forms.Label();
            this.txtBusc = new System.Windows.Forms.TextBox();
            this.dtgvBusc = new System.Windows.Forms.DataGridView();
            this.btnBusc = new System.Windows.Forms.Button();
            this.grBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBusc)).BeginInit();
            this.SuspendLayout();
            // 
            // grBus
            // 
            this.grBus.Controls.Add(this.rdbDescr);
            this.grBus.Controls.Add(this.rdbCod);
            this.grBus.Controls.Add(this.rdbTodos);
            this.grBus.Location = new System.Drawing.Point(12, 27);
            this.grBus.Name = "grBus";
            this.grBus.Size = new System.Drawing.Size(200, 100);
            this.grBus.TabIndex = 0;
            this.grBus.TabStop = false;
            this.grBus.Text = "Pesquisar Produtos:";
            // 
            // rdbDescr
            // 
            this.rdbDescr.AutoSize = true;
            this.rdbDescr.Location = new System.Drawing.Point(6, 65);
            this.rdbDescr.Name = "rdbDescr";
            this.rdbDescr.Size = new System.Drawing.Size(76, 17);
            this.rdbDescr.TabIndex = 2;
            this.rdbDescr.TabStop = true;
            this.rdbDescr.Text = "Descrição:";
            this.rdbDescr.UseVisualStyleBackColor = true;
            // 
            // rdbCod
            // 
            this.rdbCod.AutoSize = true;
            this.rdbCod.Location = new System.Drawing.Point(6, 42);
            this.rdbCod.Name = "rdbCod";
            this.rdbCod.Size = new System.Drawing.Size(106, 17);
            this.rdbCod.TabIndex = 1;
            this.rdbCod.TabStop = true;
            this.rdbCod.Text = "Codigo de barra :";
            this.rdbCod.UseVisualStyleBackColor = true;
            this.rdbCod.CheckedChanged += new System.EventHandler(this.rdbCod_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(6, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(58, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos:";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // lblBuc
            // 
            this.lblBuc.Location = new System.Drawing.Point(228, 27);
            this.lblBuc.Name = "lblBuc";
            this.lblBuc.Size = new System.Drawing.Size(173, 23);
            this.lblBuc.TabIndex = 1;
            // 
            // txtBusc
            // 
            this.txtBusc.Location = new System.Drawing.Point(231, 53);
            this.txtBusc.Name = "txtBusc";
            this.txtBusc.Size = new System.Drawing.Size(170, 20);
            this.txtBusc.TabIndex = 2;
            // 
            // dtgvBusc
            // 
            this.dtgvBusc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBusc.Location = new System.Drawing.Point(18, 133);
            this.dtgvBusc.Name = "dtgvBusc";
            this.dtgvBusc.Size = new System.Drawing.Size(517, 147);
            this.dtgvBusc.TabIndex = 3;
            // 
            // btnBusc
            // 
            this.btnBusc.Location = new System.Drawing.Point(240, 92);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(75, 23);
            this.btnBusc.TabIndex = 4;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 318);
            this.Controls.Add(this.btnBusc);
            this.Controls.Add(this.dtgvBusc);
            this.Controls.Add(this.txtBusc);
            this.Controls.Add(this.lblBuc);
            this.Controls.Add(this.grBus);
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            this.grBus.ResumeLayout(false);
            this.grBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBusc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBus;
        private System.Windows.Forms.RadioButton rdbDescr;
        private System.Windows.Forms.RadioButton rdbCod;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label lblBuc;
        private System.Windows.Forms.TextBox txtBusc;
        private System.Windows.Forms.DataGridView dtgvBusc;
        private System.Windows.Forms.Button btnBusc;
    }
}