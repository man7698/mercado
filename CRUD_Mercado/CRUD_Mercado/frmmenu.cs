using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRUD_Mercado.consultas;

namespace CRUD_Mercado
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void frenteDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfrentedecaixa caixa = new frmfrentedecaixa();
            caixa.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadastroproduto cadprod = new frmcadastroproduto();
            cadprod.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadastrofuncionario cadfunc = new frmcadastrofuncionario();
            cadfunc.ShowDialog();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmconsultafuncionario confunc = new frmconsultafuncionario();
            confunc.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmconsultaproduto conprod = new frmconsultaproduto();
            conprod.ShowDialog();
        }
    }
}
