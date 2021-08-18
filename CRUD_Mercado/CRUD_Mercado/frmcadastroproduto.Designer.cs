namespace CRUD_Mercado
{
    partial class frmcadastroproduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadastroproduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncadastrafunc = new System.Windows.Forms.Button();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtqtestoque = new System.Windows.Forms.TextBox();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.txtcodproduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btncadastrafunc);
            this.groupBox1.Controls.Add(this.txtpreco);
            this.groupBox1.Controls.Add(this.txtqtestoque);
            this.groupBox1.Controls.Add(this.txtnomeproduto);
            this.groupBox1.Controls.Add(this.txtcodproduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btncadastrafunc
            // 
            this.btncadastrafunc.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrafunc.Image = ((System.Drawing.Image)(resources.GetObject("btncadastrafunc.Image")));
            this.btncadastrafunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncadastrafunc.Location = new System.Drawing.Point(272, 253);
            this.btncadastrafunc.Name = "btncadastrafunc";
            this.btncadastrafunc.Size = new System.Drawing.Size(138, 40);
            this.btncadastrafunc.TabIndex = 8;
            this.btncadastrafunc.Text = "Cadastrar";
            this.btncadastrafunc.UseVisualStyleBackColor = true;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(269, 186);
            this.txtpreco.Multiline = true;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(141, 27);
            this.txtpreco.TabIndex = 7;
            this.txtpreco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtqtestoque
            // 
            this.txtqtestoque.Location = new System.Drawing.Point(269, 141);
            this.txtqtestoque.Multiline = true;
            this.txtqtestoque.Name = "txtqtestoque";
            this.txtqtestoque.Size = new System.Drawing.Size(141, 27);
            this.txtqtestoque.TabIndex = 6;
            this.txtqtestoque.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Location = new System.Drawing.Point(269, 99);
            this.txtnomeproduto.Multiline = true;
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(141, 27);
            this.txtnomeproduto.TabIndex = 5;
            this.txtnomeproduto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtcodproduto
            // 
            this.txtcodproduto.Location = new System.Drawing.Point(269, 54);
            this.txtcodproduto.Multiline = true;
            this.txtcodproduto.Name = "txtcodproduto";
            this.txtcodproduto.Size = new System.Drawing.Size(141, 27);
            this.txtcodproduto.TabIndex = 4;
            this.txtcodproduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade em Estoque:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do produto:";
            // 
            // frmcadastroproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmcadastroproduto";
            this.Text = "Cadastros de produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtqtestoque;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.TextBox txtcodproduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncadastrafunc;
    }
}