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
    public partial class frmcadastrofuncionario : Form
    {
        public frmcadastrofuncionario()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;

        public int pegarid()
        {

            da = new SqlDataAdapter("select MAX (idfuncionario) + 1 from funcionario ", con);

            DataSet ds = new DataSet();

            da.Fill(ds);

                return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand("insert into funcionario (idfuncionario,nome_funcionario,cpf,cargo,salario) values("+pegarid()+",'"+txtnome.Text+"','"+txtcpf.Text+"','"+cbcargo.Text+"',"+decimal.Parse(txtsalario.Text)+")",con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado !!!");
            }
            catch(Exception E)
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
