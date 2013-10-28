using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtributosMetodosEstaticos
{
    class Pessoas
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private static int contadorPessoas = 0;
        public static int ContadorPessoas
        {
            get { return Pessoas.contadorPessoas; }
            set { Pessoas.contadorPessoas = value; }
        }

        public Pessoas()
        {
            ContadorPessoas++;
        }

        public Pessoas(String pessoa)
        {
            ContadorPessoas++;
            this.Nome = pessoa;
        }

        public virtual String GetInfo()
        {
            return this.Nome;
        }





    }
}
