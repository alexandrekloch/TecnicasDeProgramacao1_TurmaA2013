using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassesWeb
{
    public partial class CalendarioDeAniversarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            List<Pessoa> lst = new List<Pessoa>();
            lst = Pessoa.ListarAniverssariantes(new DateTime(1977,07,20));

            foreach (var item in lst)
            {
                Literal l = new Literal();
                l.Text = item.nome + "<br/>";
                form1.Controls.Add(l);
            }
        }
    }
}