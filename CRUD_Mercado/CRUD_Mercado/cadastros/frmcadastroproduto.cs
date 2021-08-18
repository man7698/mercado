using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUD_Mercado
{
    public partial class frmcadastroproduto : Form
    {
        public frmcadastroproduto()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        SqlCommand cmd;


        private void btncadastrafunc_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into produtos (idproduto,nome_produto,quantidade,preco) values(" + int.Parse(txtcodproduto.Text) + ",'" + txtnomeproduto.Text + "'," + int.Parse(txtqtestoque.Text) + "," + decimal.Parse(txtpreco.Text) + "" + ")", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado !!!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
