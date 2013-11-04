using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassesWeb
{
    public class Pessoa
    {
        public String nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public String redeSocial { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(String nome, DateTime dataNascimento, String redeSocial) 
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.redeSocial = redeSocial;
        }

        public static List<Pessoa> ListarAniverssariantes(DateTime data)
        {
            List<Pessoa> lista = new List<Pessoa>();
            
            lista.Add(new Pessoa("Alexandre Luis Kloch", new DateTime(1977, 12,20),"https://www.facebook.com/alexandre.kloch"));
            lista.Add(new Pessoa("Karine", new DateTime(1980, 07, 20), "https://www.facebook.com/alexandre.kloch"));
            lista.Add(new Pessoa("Eduardo", new DateTime(2011, 04, 11), "https://www.facebook.com/alexandre.kloch"));
            lista.Add(new Pessoa("Juraci", new DateTime(1939, 07, 18), "https://www.facebook.com/alexandre.kloch"));
            

            List<Pessoa> aniversarianteMes = lista.FindAll(
                delegate(Pessoa p1) 
                {
                    return p1.dataNascimento.Date.Month == data.Month ; 
                });

            //List<Pessoa> aniversariantedia = aniversarianteMes.FindAll(
            //    delegate(Pessoa p1)
            //    {
            //        return p1.dataNascimento.Date.Day == data.Day;
            //    });
            return aniversarianteMes;


 
        }
    }
}