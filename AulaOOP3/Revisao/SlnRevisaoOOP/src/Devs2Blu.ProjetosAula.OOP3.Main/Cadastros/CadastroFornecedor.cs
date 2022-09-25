using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor
    {
        public CadastroFornecedor()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
                Console.WriteLine("***** Cadastro de Fornecedor *****");
                Console.WriteLine("----- 1 - Lista de Fornecedores -----");
                Console.WriteLine("----- 2 - Cadastro de Fornecedor -----");
                Console.WriteLine("----- 3 - Alterar Fornecedor -----");
                Console.WriteLine("-----------------------");
                Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarFornecedores();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarFornecedor();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarFornecedor();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirFornecedor();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarFornecedores()
        {
            Console.Clear();

            foreach(Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo de Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------------\n");
            }
        }

        public void CadastrarFornecedor()
        {
            Console.Clear();
            //Program.Mock.ListaFornecedores.Add(novoFornecedor);
            Console.WriteLine("Em construção!");
        }

        public void AlterarFornecedor()
        {
            Console.Clear();
            Console.WriteLine("Em construção!");
        }

        public void ExcluirFornecedor()
        {
            Console.Clear();
            Console.WriteLine("Em construção!");
        }
    }
}
