using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Fornecedor : Pessoa
    {
        public Int32 CodigoFornecedor { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor()
        {
            TipoPessoa = TipoPessoa.PJ;
        }

        public Fornecedor(Int32 codigo, String nome, String cnpj, String tipoFornecedor)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cnpj;
            TipoPessoa = TipoPessoa.PJ;
            TipoFornecedor = tipoFornecedor;

            Random rd = new Random();
            CodigoFornecedor = Int32.Parse($"{codigo}{rd.Next(10, 100)}");
        }
    }
}
