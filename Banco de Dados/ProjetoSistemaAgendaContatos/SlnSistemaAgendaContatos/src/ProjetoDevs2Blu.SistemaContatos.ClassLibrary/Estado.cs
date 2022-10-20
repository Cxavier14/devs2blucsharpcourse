using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDevs2Blu.SistemaContatos.ClassLibrary
{
    public class Estado
    {
        public Int32 Id { get; set; }
        public String UF { get; set; }
        public String Descricao { get; set; }

        public Estado()
        {

        }

        public Estado(int id, string uF, string descricao)
        {
            Id = id;
            UF = uF;
            Descricao = descricao;
        }
    }
}
