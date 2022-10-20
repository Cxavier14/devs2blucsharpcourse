using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDevs2Blu.SistemaContatos.ClassLibrary
{
    public class Contato
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String RedeSocial { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public Estado UF { get; set; }
        public Compromisso Compromisso { get; set; }

        public Contato()
        {

        }

        public Contato(int id, string nome, string telefone, string email, string redeSocial, string rua, int numero, string bairro, string cidade, Estado uF)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            RedeSocial = redeSocial;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }

        public Contato(int id, string nome, string telefone, string email, string redeSocial, string rua, int numero, string bairro, string cidade, Estado uF, Compromisso compromisso) 
            : this(id, nome, telefone, email, redeSocial, rua, numero, bairro, cidade, uF)
        {
            Compromisso = compromisso;
        }
    }
}
