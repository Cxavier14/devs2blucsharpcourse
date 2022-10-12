using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDevs2Blu.SistemaContatos.ClassLibrary.Enums
{
    public enum DiasSemana
    {
        [Description("Domingo")]
        Dom = 1,
        [Description("Segunda")]
        Seg = 2,
        [Description("Terça")]
        Ter = 3,
        [Description("Quarta")]
        Qua = 4,
        [Description("Quinta")]
        Qui = 5,
        [Description("Sexta")]
        Sex = 6,
        [Description("Sabado")]
        Sab = 7
    }
}
