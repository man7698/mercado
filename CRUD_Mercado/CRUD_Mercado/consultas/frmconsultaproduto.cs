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

namespace CRUD_Mercado.consultas
{
    public partial class frmconsultaproduto : Form
    {
        public frmconsultaproduto()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;

        int indice;

        private void txtpesquisaprod_KeyUp(object sender, KeyEventArgs e)
        {
            da = new SqlDataAdapter("select * from produtos where nome_produto like '" + txtpesquisaprod.Text + "%'", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gvprod.DataSource = dt;
        }

        private void gvprod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            indice = int.Parse(gvprod.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtaltnome.Text = gvprod.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtaltqt.Text = gvprod.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtaltpreco.Text = gvprod.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("update produtos set nome_produto = '" + txtaltnome.Text + "',quantidade='" + txtaltqt.Text + "',preco=" + txtaltpreco.Text +" where idproduto = " + indice + "", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração feita !!!");
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

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            

            cmd = new SqlCommand("delete produtos where idproduto ='" + indice+"'", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos !!!");
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
