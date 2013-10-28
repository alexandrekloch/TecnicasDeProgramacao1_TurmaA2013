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

            Pessoas p3 = new Pessoas("Karine");
            listBox1.Items.Add(p2.Nome);
            listBox1.Items.Add(Pessoas.ContadorPessoas.ToString());

            Pessoas p4 = new Pessoas("Polly");
            listBox1.Items.Add(p2.Nome);
            listBox1.Items.Add(Pessoas.ContadorPessoas.ToString());

            PessoaFisica pf1 = new PessoaFisica("Alexandre Luis Kloch","000000000","111111111");

            PessoaJuridica pj1 = new PessoaJuridica();
            pj1.Nome = "Empresa do Zé Tião";
            pj1.INSC = "INSC do Zé Tião";
            pj1.CNPJ = "CNPJ do Zé Tião";
            pj1.Socio = pf1;

            listBox1.Items.Add(p1.GetInfo());
            listBox1.Items.Add(pf1.GetInfo());
            listBox1.Items.Add(pj1.GetInfo());


        }
    }
}
