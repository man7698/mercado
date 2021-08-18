namespace CRUD_Mercado.consultas
{
    partial class frmconsultaproduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsultaproduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.txtaltpreco = new System.Windows.Forms.TextBox();
            this.txtaltqt = new System.Windows.Forms.TextBox();
            this.txtaltnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.gvprod = new System.Windows.Forms.DataGridView();
            this.txtpesquisaprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfinalizarvenda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gvprod);
            this.panel1.Controls.Add(this.txtpesquisaprod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnfinalizarvenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 500);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexcluir);
            this.groupBox1.Controls.Add(this.txtaltpreco);
            this.groupBox1.Controls.Add(this.txtaltqt);
            this.groupBox1.Controls.Add(this.txtaltnome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnalterar);
            this.groupBox1.Location = new System.Drawing.Point(13, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 218);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Dados";
            this.groupBox1.Visible = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(17, 165);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(122, 48);
            this.btnexcluir.TabIndex = 33;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // txtaltpreco
            // 
            this.txtaltpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltpreco.Location = new System.Drawing.Point(498, 86);
            this.txtaltpreco.Multiline = true;
            this.txtaltpreco.Name = "txtaltpreco";
            this.txtaltpreco.Size = new System.Drawing.Size(141, 27);
            this.txtaltpreco.TabIndex = 32;
            // 
            // txtaltqt
            // 
            this.txtaltqt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltqt.Location = new System.Drawing.Point(244, 91);
            this.txtaltqt.Multiline = true;
            this.txtaltqt.Name = "txtaltqt";
            this.txtaltqt.Size = new System.Drawing.Size(141, 27);
            this.txtaltqt.TabIndex = 31;
            // 
            // txtaltnome
            // 
            this.txtaltnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltnome.Location = new System.Drawing.Point(326, 30);
            this.txtaltnome.Multiline = true;
            this.txtaltnome.Name = "txtaltnome";
            this.txtaltnome.Size = new System.Drawing.Size(203, 27);
            this.txtaltnome.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantidade em Estoque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nome do Produto:";
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(611, 152);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(122, 48);
            this.btnalterar.TabIndex = 24;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // gvprod
            // 
            this.gvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvprod.Location = new System.Drawing.Point(116, 56);
            this.gvprod.Name = "gvprod";
            this.gvprod.Size = new System.Drawing.Size(536, 193);
            this.gvprod.TabIndex = 11;
            this.gvprod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvprod_CellClick);
            // 
            // txtpesquisaprod
            // 
            this.txtpesquisaprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisaprod.Location = new System.Drawing.Point(268, 23);
            this.txtpesquisaprod.Multiline = true;
            this.txtpesquisaprod.Name = "txtpesquisaprod";
            this.txtpesquisaprod.Size = new System.Drawing.Size(212, 27);
            this.txtpesquisaprod.TabIndex = 10;
            this.txtpesquisaprod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpesquisaprod_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite Nome do Produto:";
            // 
            // btnfinalizarvenda
            // 
            this.btnfinalizarvenda.Enabled = false;
            this.btnfinalizarvenda.Image = ((System.Drawing.Image)(resources.GetObject("btnfinalizarvenda.Image")));
            this.btnfinalizarvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfinalizarvenda.Location = new System.Drawing.Point(23, 506);
            this.btnfinalizarvenda.Name = "btnfinalizarvenda";
            this.btnfinalizarvenda.Size = new System.Drawing.Size(148, 37);
            this.btnfinalizarvenda.TabIndex = 7;
            this.btnfinalizarvenda.Text = "Finalizar Venda";
            this.btnfinalizarvenda.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(482, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // frmconsultaproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.panel1);
            this.Name = "frmconsultaproduto";
            this.Text = "frmconsultaproduto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvprod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.DataGridView gvprod;
        private System.Windows.Forms.TextBox txtpesquisaprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfinalizarvenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaltpreco;
        private System.Windows.Forms.TextBox txtaltqt;
        private System.Windows.Forms.TextBox txtaltnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnexcluir;

    }
}