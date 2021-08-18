namespace CRUD_Mercado
{
    partial class frmfrentedecaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfrentedecaixa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfinalizarvenda = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtqauntidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigoproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvitens = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.btniniciarvenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvitens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnfinalizarvenda);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 568);
            this.panel1.TabIndex = 0;
            // 
            // btnfinalizarvenda
            // 
            this.btnfinalizarvenda.Image = ((System.Drawing.Image)(resources.GetObject("btnfinalizarvenda.Image")));
            this.btnfinalizarvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfinalizarvenda.Location = new System.Drawing.Point(23, 506);
            this.btnfinalizarvenda.Name = "btnfinalizarvenda";
            this.btnfinalizarvenda.Size = new System.Drawing.Size(148, 37);
            this.btnfinalizarvenda.TabIndex = 7;
            this.btnfinalizarvenda.Text = "Finalizar Venda";
            this.btnfinalizarvenda.UseVisualStyleBackColor = true;
            this.btnfinalizarvenda.Click += new System.EventHandler(this.btnfinalizarvenda_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(592, 512);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(61, 36);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "R$";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 124);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtqauntidade);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcodigoproduto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gvitens);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 356);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpreco.Location = new System.Drawing.Point(21, 222);
            this.txtpreco.Multiline = true;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(154, 30);
            this.txtpreco.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preço:";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(160, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "retirar item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(6, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Incluir item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtqauntidade
            // 
            this.txtqauntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtqauntidade.Location = new System.Drawing.Point(21, 142);
            this.txtqauntidade.Multiline = true;
            this.txtqauntidade.Name = "txtqauntidade";
            this.txtqauntidade.Size = new System.Drawing.Size(154, 30);
            this.txtqauntidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // txtcodigoproduto
            // 
            this.txtcodigoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcodigoproduto.Location = new System.Drawing.Point(21, 70);
            this.txtcodigoproduto.Multiline = true;
            this.txtcodigoproduto.Name = "txtcodigoproduto";
            this.txtcodigoproduto.Size = new System.Drawing.Size(154, 30);
            this.txtcodigoproduto.TabIndex = 2;
            this.txtcodigoproduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcodigoproduto_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo do Produto:";
            // 
            // gvitens
            // 
            this.gvitens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvitens.Location = new System.Drawing.Point(329, 19);
            this.gvitens.Name = "gvitens";
            this.gvitens.Size = new System.Drawing.Size(535, 331);
            this.gvitens.TabIndex = 0;
            this.gvitens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvitens_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldata);
            this.groupBox1.Controls.Add(this.btniniciarvenda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtvendedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Venda";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbldata.Location = new System.Drawing.Point(409, 16);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 21);
            this.lbldata.TabIndex = 3;
            // 
            // btniniciarvenda
            // 
            this.btniniciarvenda.Enabled = false;
            this.btniniciarvenda.Image = ((System.Drawing.Image)(resources.GetObject("btniniciarvenda.Image")));
            this.btniniciarvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniniciarvenda.Location = new System.Drawing.Point(557, 58);
            this.btniniciarvenda.Name = "btniniciarvenda";
            this.btniniciarvenda.Size = new System.Drawing.Size(148, 37);
            this.btniniciarvenda.TabIndex = 2;
            this.btniniciarvenda.Text = "Iniciar Venda";
            this.btniniciarvenda.UseVisualStyleBackColor = true;
            this.btniniciarvenda.Click += new System.EventHandler(this.btniniciarvenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do Vendedor:";
            // 
            // txtvendedor
            // 
            this.txtvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtvendedor.Location = new System.Drawing.Point(197, 16);
            this.txtvendedor.Multiline = true;
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(127, 29);
            this.txtvendedor.TabIndex = 1;
            this.txtvendedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtvendedor_KeyUp);
            // 
            // frmfrentedecaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.panel1);
            this.Name = "frmfrentedecaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmfrentedecaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvitens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtvendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btniniciarvenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvitens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtqauntidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigoproduto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnfinalizarvenda;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label6;
    }
}