namespace CRUD_Mercado.consultas
{
    partial class frmconsultafuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsultafuncionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaltsalario = new System.Windows.Forms.TextBox();
            this.cbaltcargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtaltnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaltcpf = new System.Windows.Forms.TextBox();
            this.gvfunc = new System.Windows.Forms.DataGridView();
            this.txtpesquisafunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfinalizarvenda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gvfunc);
            this.panel1.Controls.Add(this.txtpesquisafunc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnfinalizarvenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 505);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexcluir);
            this.groupBox1.Controls.Add(this.btnalterar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtaltsalario);
            this.groupBox1.Controls.Add(this.cbaltcargo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtaltnome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtaltcpf);
            this.groupBox1.Location = new System.Drawing.Point(13, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 218);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Dados";
            this.groupBox1.Visible = false;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Salario:";
            // 
            // txtaltsalario
            // 
            this.txtaltsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltsalario.Location = new System.Drawing.Point(426, 87);
            this.txtaltsalario.Multiline = true;
            this.txtaltsalario.Name = "txtaltsalario";
            this.txtaltsalario.Size = new System.Drawing.Size(141, 27);
            this.txtaltsalario.TabIndex = 22;
            // 
            // cbaltcargo
            // 
            this.cbaltcargo.FormattingEnabled = true;
            this.cbaltcargo.Items.AddRange(new object[] {
            "Administrador",
            "Caixa",
            "Logística",
            "Faxina",
            "Almoxarifado"});
            this.cbaltcargo.Location = new System.Drawing.Point(129, 92);
            this.cbaltcargo.Name = "cbaltcargo";
            this.cbaltcargo.Size = new System.Drawing.Size(141, 21);
            this.cbaltcargo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cargo:";
            // 
            // txtaltnome
            // 
            this.txtaltnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltnome.Location = new System.Drawing.Point(239, 23);
            this.txtaltnome.Multiline = true;
            this.txtaltnome.Name = "txtaltnome";
            this.txtaltnome.Size = new System.Drawing.Size(141, 27);
            this.txtaltnome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome do Funcionario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cpf:";
            // 
            // txtaltcpf
            // 
            this.txtaltcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltcpf.Location = new System.Drawing.Point(486, 26);
            this.txtaltcpf.Multiline = true;
            this.txtaltcpf.Name = "txtaltcpf";
            this.txtaltcpf.Size = new System.Drawing.Size(141, 27);
            this.txtaltcpf.TabIndex = 15;
            // 
            // gvfunc
            // 
            this.gvfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvfunc.Location = new System.Drawing.Point(90, 56);
            this.gvfunc.Name = "gvfunc";
            this.gvfunc.Size = new System.Drawing.Size(583, 193);
            this.gvfunc.TabIndex = 11;
            this.gvfunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvfunc_CellClick);
            // 
            // txtpesquisafunc
            // 
            this.txtpesquisafunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisafunc.Location = new System.Drawing.Point(268, 23);
            this.txtpesquisafunc.Multiline = true;
            this.txtpesquisafunc.Name = "txtpesquisafunc";
            this.txtpesquisafunc.Size = new System.Drawing.Size(212, 27);
            this.txtpesquisafunc.TabIndex = 10;
            this.txtpesquisafunc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpesquisafunc_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite Nome do Funcionario:";
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
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(10, 152);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(122, 48);
            this.btnexcluir.TabIndex = 25;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // frmconsultafuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 505);
            this.Controls.Add(this.panel1);
            this.Name = "frmconsultafuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar e Alterar Funcionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvfunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfinalizarvenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvfunc;
        private System.Windows.Forms.TextBox txtpesquisafunc;
        private System.Windows.Forms.TextBox txtaltnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaltcpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaltsalario;
        private System.Windows.Forms.ComboBox cbaltcargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
    }
}