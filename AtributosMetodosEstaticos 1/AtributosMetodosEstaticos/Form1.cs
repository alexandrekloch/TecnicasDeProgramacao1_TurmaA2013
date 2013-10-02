using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtributosMetodosEstaticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoas p1 = new Pessoas();
            p1.Nome = "Alexandre";
            

            listBox1.Items.Add(p1.Nome);
            listBox1.Items.Add(Pessoas.ContadorPessoas.ToString());

            Pessoas p2 = new Pessoas();
            p2.Nome = "Eduardo";
            

            listBox1.Items.Add(p2.Nome);
            listBox1.Items.Add(Pessoas.ContadorPessoas.ToString());




        }
    }
}
