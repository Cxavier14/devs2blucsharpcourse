using ProjetoDevs2Blu.SistemaContatos.ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDevs2Blu.SistemaContatos.ClassLibrary
{
    public class Compromisso
    {
        public Int32 Id { get; set; }
        public String Titulo { get; set; }
        public Contato Contato { get; set; }
        public DiasSemana Dia { get; set; }
        public DateTime Data { get; set; }
        public FlStatus Status { get; set; }

        public Compromisso()
        {
            Status = FlStatus.A;
        }

        public Compromisso(int id, string titulo, DiasSemana dia, DateTime data)
        {
            Id = id;
            Titulo = titulo;
            Dia = dia;
            Data = data;
            Status = FlStatus.A;
        }

        public Compromisso(int id, string titulo, DiasSemana dia, DateTime data, Contato contato)
        {
            Id = id;
            Titulo = titulo;
            Contato = contato;
            Dia = dia;
            Data = data;
            Status = FlStatus.A;
        }

        public Compromisso(int id, string titulo, DiasSemana dia, DateTime data, FlStatus status, Contato contato)
        {
            Id = id;
            Titulo = titulo;
            Contato = contato;
            Dia = dia;
            Data = data;
            Status = status;
        }
    }
}
