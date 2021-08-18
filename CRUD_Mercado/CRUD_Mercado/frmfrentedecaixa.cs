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
    public partial class frmfrentedecaixa : Form
    {
        public frmfrentedecaixa()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        int indice;
        int numvenda;
        int somaqt;

        public int novavenda()
        {
            da = new SqlDataAdapter("select MAX (idvenda) + 1 from vendas",con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
              
        }


        public void btniniciarvenda_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("insert into vendas (idvenda,data,idfuncionario)values("+novavenda()+",'"+lbldata.Text+"',"+txtvendedor.Text+")", con);

            try
            {
                numvenda = novavenda();
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda Iniciada !!!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                con.Close();
            }


            groupBox2.Enabled = true;
        }

        private void frmfrentedecaixa_Load(object sender, EventArgs e)
        {
            lbldata.Text = DateTime.Now.ToShortDateString();
        }


        private void txtvendedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtvendedor.Text != null)
            {
                btniniciarvenda.Enabled = true;
            }
        }

        private void txtcodigoproduto_KeyUp(object sender, KeyEventArgs e)
        {

            cmd = new SqlCommand("select * from produtos where idproduto like '" + txtcodigoproduto.Text+"%'", con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                txtpreco.Text = dr["preco"].ToString();
                


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

        public int novoitem()
        {
            da = new SqlDataAdapter("select MAX (id_itens) + 1 from itens_venda", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());

        }

        public int total()
        {
            da = new SqlDataAdapter("select sum (preco * quantidade) from itens_venda where idvenda ="+numvenda, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand("insert into itens_venda(id_itens,idvenda,idproduto,quantidade,preco)values("+novoitem()+","+numvenda+","+int.Parse(txtcodigoproduto.Text)+","+int.Parse(txtqauntidade.Text)+","+decimal.Parse(txtpreco.Text)+")", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                con.Close();
                somaqt += int.Parse(txtqauntidade.Text);

            }
            listaritens();
            lbltotal.Text = "R$ " + total();



        }

        public void listaritens()
        {
            da = new SqlDataAdapter("select iv.id_itens,p.idproduto,p.nome_produto,iv.quantidade,iv.preco,(iv.quantidade * iv.preco) as subtotal from itens_venda as iv inner join produtos as p on p.idproduto = iv.idproduto where idvenda ="+numvenda, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gvitens.DataSource = dt;
  

        }

        private void btnfinalizarvenda_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            numvenda = 0;
            txtcodigoproduto.Clear();
            txtpreco.Clear();
            txtqauntidade.Clear();
            txtvendedor.Clear();

            MessageBox.Show(" O Total é  R$ "+lbltotal.Text);

            
                string query = @"update produtos set quantidade = (produtos.quantidade - {0}) where idproduto = {1}";
                for (int i = 0; i < gvitens.RowCount - 1; i++)
                {
                    int iQuantidade, iCodigo;
                    int.TryParse(gvitens.Rows[i].Cells["quantidade"].Value.ToString(), out iQuantidade);
                    int.TryParse(gvitens.Rows[i].Cells["idproduto"].Value.ToString(), out iCodigo);
                    string update = string.Format(query, iQuantidade, iCodigo);
                    cmd.Connection = con;
                    cmd.CommandText = update;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }


            lbltotal.Text = null;

            gvitens.DataSource = null;
            gvitens.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete itens_venda where id_itens = "+indice,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                con.Close();
            }

            listaritens();



        }

        private void gvitens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = int.Parse(gvitens.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

    }
}
