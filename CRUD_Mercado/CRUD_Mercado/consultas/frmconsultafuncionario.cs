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
    public partial class frmconsultafuncionario : Form
    {
        public frmconsultafuncionario()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        private void txtpesquisafunc_KeyUp(object sender, KeyEventArgs e)
        {
            da = new SqlDataAdapter("select * from funcionario where nome_funcionario like '"+txtpesquisafunc.Text +"%'",con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gvfunc.DataSource = dt;

        }
        int indice;
        private void gvfunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             groupBox1.Visible = true;
             indice = int.Parse(gvfunc.Rows[e.RowIndex].Cells[0].Value.ToString());
             txtaltnome.Text = gvfunc.Rows[e.RowIndex].Cells[1].Value.ToString();
             txtaltcpf.Text = gvfunc.Rows[e.RowIndex].Cells[2].Value.ToString();
             cbaltcargo.Text = gvfunc.Rows[e.RowIndex].Cells[3].Value.ToString();
             txtaltsalario.Text = gvfunc.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("update funcionario set nome_funcionario = '" + txtaltnome.Text + "',cpf='" + txtaltcpf.Text + "',cargo='" + cbaltcargo.Text + "',salario=" + txtaltsalario.Text + " where idfuncionario = " +indice + "", con);

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
            

            cmd = new SqlCommand("delete funcionario where idfuncionario =" + indice, con);

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
