using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDWindowsForms
{
    public partial class Form1 : Form
    {
        String status = "novo";
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable SelecionaContatos()
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();


            try
            {
                conn.ConnectionString = Properties.Settings.Default.csBDContatos;
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "SELECT * FROM tblContatos";
                da.SelectCommand.Connection = conn;
                da.SelectCommand.CommandType = CommandType.Text;

                da.Fill(dt);

                return dt;

            }
            catch (SqlException ex)
            {
                throw new Exception("Sql Exception " + ex.Number);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            lstContatos.Items.Clear();
            DataTable contatos = SelecionaContatos();
            foreach (DataRow contato in contatos.Rows)
            {
                ListViewItem list = new ListViewItem(contato["id"].ToString());
                list.SubItems.Add(contato["Nome"].ToString());
                list.SubItems.Add(contato["Email"].ToString());
                lstContatos.Items.Add(list);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtEmail.Text != ""))
            {
                if (status == "novo")
                {
                   CriarContato(txtNome.Text, txtEmail.Text);
                   LimparFormulario();
                   AtualizaLista();
                }
                else if (status == "editar")
                {
                    int num = Convert.ToInt32(lstContatos.Items[lstContatos.FocusedItem.Index].Text);
                    AtulizaContato(num, txtNome.Text, txtEmail.Text);
                    LimparFormulario();
                    AtualizaLista();
                    status = "novo";
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo!!!");
            }
        }

        private void AtulizaContato(int num, string nome, string email)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand da = new SqlCommand();

            try
            {
                conn.ConnectionString = Properties.Settings.Default.csBDContatos;
                da.CommandText = "Update tblContatos set nome '" + nome +
                                                     "', email = '" + email + 
                                                     "' where id = " + num;
                da.Connection = conn;
                da.CommandType = CommandType.Text;
                conn.Open();
                da.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Exception " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Contato Deletado com sucesso!!");
            }
        }

        private void LimparFormulario()
        {
            txtEmail.Clear();
            txtNome.Clear();
        }

        private void CriarContato(string nome, string email)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand da = new SqlCommand();
            
            try
            {
                conn.ConnectionString = Properties.Settings.Default.csBDContatos;
                da.CommandText = "Insert INTO tblContatos(Nome,Email) Values( '" + nome + "','" + email + "')";
                da.Connection = conn;
                da.CommandType = CommandType.Text;
                conn.Open();
                da.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Exception " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Contato cadastrado com sucesso!!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(lstContatos.Items[lstContatos.FocusedItem.Index].Text);
            
            DeletarContato(num);
            AtualizaLista();
        }

        private void DeletarContato(int id)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand da = new SqlCommand();

            try
            {
                conn.ConnectionString = Properties.Settings.Default.csBDContatos;
                da.CommandText = "Delete FROM tblContatos where id =" + id;
                da.Connection = conn;
                da.CommandType = CommandType.Text;
                conn.Open();
                da.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Exception " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Contato Deletado com sucesso!!");
            }
        }

        private void lstContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstContatos_Click(object sender, EventArgs e)
        {
            txtNome.Text = lstContatos.Items[lstContatos.FocusedItem.Index].SubItems[1].Text; 
            txtEmail.Text = lstContatos.Items[lstContatos.FocusedItem.Index].SubItems[2].Text;
            status = "editar";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
