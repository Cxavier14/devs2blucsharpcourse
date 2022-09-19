using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Diretor : Pessoa
    {
        public double Prolabore { get; set; }

        public Diretor() { }

        public Diretor(string nome, string sobrenome, double prolabore)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Prolabore = prolabore;
        }

        public string VerificaStatus()
        {
            return "Hospital OK!";
        }
    }
}
