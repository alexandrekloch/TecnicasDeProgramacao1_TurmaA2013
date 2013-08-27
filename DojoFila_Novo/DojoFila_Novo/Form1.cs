using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DojoFila_Novo
{
    public partial class Form1 : Form
    {
        int[] numerosSorteados = new int[10];

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

        private void button1_Click(object sender, EventArgs e)
        {
            String[] Pessoas = {"Pessoa1", "Pessoa2", "Pessoa3", "Pessoa4", "Pessoa5", 
                                 "Pessoa6", "Pessoa7", "Pessoa8","Pessoa9","Pessoa10"
                               };

            for (int i = Pessoas.Count(); i > 0; i--)
            {
                lstFila.Items.Add(Pessoas[i - 1]);
            }
                
            foreach (var pessoa in Pessoas)
            {
                lstFila.Items.Add(pessoa);
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            LimpaVetor();
            Random aleatorio = new Random();
            for (int i = 0; i < 10; i++)
            {
                Boolean retorno;
                int numero;
                do
                {
                    numero = aleatorio.Next(0, 11);
                    retorno = VerificaVetor(numero);
                } while (retorno);
                numerosSorteados[i] = numero;
            }
            foreach (var num in numerosSorteados)
            {
                lstFila.Items.Add(num);
            }
        }

        private Boolean VerificaVetor(int numero)
        {
            foreach (var num in numerosSorteados)
            { 
                if (numero == num || numero == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void LimpaVetor()
        {
            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                numerosSorteados[i] = 0;
            }
        }
    }
}
