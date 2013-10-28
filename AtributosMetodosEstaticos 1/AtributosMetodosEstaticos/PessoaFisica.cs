using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtributosMetodosEstaticos
{
    class PessoaFisica : Pessoas
    {
        private String _rg;

        public String Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }
        private String _cpf;

        public String Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public PessoaFisica(String nome, String cpf, String rg)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
        }

        public override String GetInfo()
        {
            return "Nome: "+ this.Nome + "Rg: " + this.Rg;
        }
       
    }
}
