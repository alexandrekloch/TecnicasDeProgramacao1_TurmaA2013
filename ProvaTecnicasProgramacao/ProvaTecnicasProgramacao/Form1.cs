using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProvaTecnicasProgramacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DataTable motos = SelecionaMotos();
            foreach (DataRow contato in motos.Rows)
            {
                ListViewItem list = new ListViewItem(contato["id"].ToString());
                list.SubItems.Add(contato["Marca"].ToString());
                list.SubItems.Add(contato["Modelo"].ToString());
                listView1.Items.Add(list);
            }
        }

        public DataTable SelecionaMotos()
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();


            try
            {
                conn.ConnectionString = Properties.Settings.Default.csProvaTP;
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "SELECT * FROM tblCatalogo";
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

        public DataTable SelecionaMotosId(int Id)
        {

            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();


            try
            {
                conn.ConnectionString = Properties.Settings.Default.csProvaTP;
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "SELECT * FROM tblCatalogo where Id=" + Id;
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

        private void listView1_Click(object sender, EventArgs e)
        {
            DataTable motos = SelecionaMotosId(Convert.ToInt32(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text));
            DataRow dr = motos.Rows[0];

            pictureBox1.Image = imageList1.Images[dr["Modelo"].ToString() + ".jpg"];

            txtMarca.Text = dr["Marca"].ToString();
            txtModelo.Text = dr["Modelo"].ToString();
            txtVelocidade.Text = dr["Velocidade"].ToString();
            txtCavalos.Text = dr["Cavalos"].ToString();
            txtCilindradas.Text = dr["Cilindradas"].ToString();
            txtPeso.Text = dr["Peso"].ToString();
        }
    }
}
