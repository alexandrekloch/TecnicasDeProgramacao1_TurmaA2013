using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpDown
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            DirectoryInfo pasta = new DirectoryInfo(@"D:\SENAI\Aulas\Tecnicas de Programação\UpDown\UpDown\Arquivos");
            FileInfo[] listaArquivos = pasta.GetFiles("*", SearchOption.TopDirectoryOnly);
            
            ListBox1.Items.Clear();
            ListBox1.DataSource = listaArquivos;
            ListBox1.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            UploadArquivo();   
        }

        private void UploadArquivo()
        {
            if (FileUpload1.FileName != "")
            {
                String NomeArquivo = FileUpload1.FileName;
                DirectoryInfo Destino = new DirectoryInfo(@"C:\ArquivosUpDown");
                FileUpload1.SaveAs(Destino.FullName + "/" + NomeArquivo);
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                Image1.ImageUrl = "~/Arquivos/" + ListBox1.SelectedValue;
        }
    }
}