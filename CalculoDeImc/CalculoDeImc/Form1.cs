using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoDeImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblValorImc.Text = CalculoIMC(nudAltura.Value, nudPeso.Value).ToString();
            lblObsImc.Text = SituacaoIMC(CalculoIMC(nudAltura.Value, nudPeso.Value));
        }

        private string SituacaoIMC(decimal Imc)
        {
            if (Imc < 18.5M)
	        {
		        return "Você esta abaixo do peso!";
	        }
            else if (Imc > 18.5M && Imc < 24.9M)
            {
                return "Parabéns — você está em seu peso normal!";
            }
            else if (Imc > 25M && Imc < 29.9M)
            {
                return "Você está acima de seu peso (sobrepeso)";
            }
            else if (Imc > 30M && Imc < 34.9M)
            {
                return "Obesidade grau I";
            }
            else if (Imc > 35M && Imc < 39.9M)
            {
                return "Obesidade grau II";
            }
            else if (Imc > 40M)
            {
                return "Obesidade grau III";
            }
            else
            {
                return "";
            }
        }

        private void radFeminino_CheckedChanged(object sender, EventArgs e)
        {
            lblValorImc.Text = CalculoIMC(nudAltura.Value, nudPeso.Value).ToString();
            lblObsImc.Text = SituacaoIMC(Convert.ToInt32(CalculoIMC(nudAltura.Value, nudPeso.Value) * 100));
        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {
            lblValorImc.Text = CalculoIMC(nudAltura.Value, nudPeso.Value).ToString();
            lblObsImc.Text = SituacaoIMC(Convert.ToInt32(CalculoIMC(nudAltura.Value, nudPeso.Value) * 100));

        }

        private void nudPeso_ValueChanged(object sender, EventArgs e)
        {
            lblValorImc.Text = CalculoIMC(nudAltura.Value, nudPeso.Value).ToString();
            lblObsImc.Text = SituacaoIMC(Convert.ToInt32(CalculoIMC(nudAltura.Value, nudPeso.Value) * 100));
        }

        private decimal CalculoIMC(decimal altura, decimal peso)
        {
            return  peso / (altura * altura);
        }

    }
}
