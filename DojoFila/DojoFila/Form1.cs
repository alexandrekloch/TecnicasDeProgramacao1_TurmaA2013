using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DojoFila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsereFim_Click(object sender, EventArgs e)
        {
            lstFila.Items.Add(txtNovoNome.Text);
        }

        private void btnMandaFim_Click(object sender, EventArgs e)
        {
            lstFila.SetSelected(0,true);
            lstFila.Items.Add(lstFila.SelectedItem);
            lstFila.Items.RemoveAt(0);
        }
    }
}
