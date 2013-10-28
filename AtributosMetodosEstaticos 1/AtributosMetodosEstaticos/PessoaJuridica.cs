using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtributosMetodosEstaticos
{
    class PessoaJuridica :Pessoas
    {
        public String CNPJ { get; set; }
        public String INSC { get; set; }
        public PessoaFisica Socio { get; set;}


    }
}
