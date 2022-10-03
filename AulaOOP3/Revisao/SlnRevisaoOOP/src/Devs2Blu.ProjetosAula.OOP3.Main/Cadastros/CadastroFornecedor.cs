using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("***** Cadastro de Fornecedor *****");
            Console.WriteLine("----- 1 - Lista de Fornecedores -----");
            Console.WriteLine("----- 2 - Cadastro de Fornecedor -----");
            Console.WriteLine("----- 3 - Alterar Fornecedor -----");
            Console.WriteLine("----- 4 - Excluir Fornecedor -----");
            Console.WriteLine("-----------------------");
            Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            Console.Clear();
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo de Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------------\n");
            }
            Console.WriteLine("Pressione Enter para voltar ao menu");
            Console.ReadLine();
        }

        public void Cadastrar()
        {
            Console.Clear();
            
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ:");
            string cnpj = Console.ReadLine();

            ListaTipoFornecedor();
            Console.WriteLine("\nInforme o tipo de fornecedor:");
            string tipoForn = Console.ReadLine();

            Random rd = new Random();
            int codigo = rd.Next(1, 9) + DateTime.Now.Second;
            int codigoFornecedor = Int32.Parse($"{codigo}{rd.Next(1,99)}");

            Program.Mock.ListaFornecedores.Add(new Fornecedor(codigoFornecedor, nome, cnpj, tipoForn));
            Console.Clear();
            Console.WriteLine("Dados cadastrados com sucesso!");
            Console.WriteLine("Pressione Enter para voltar ao menu");
            Console.ReadLine();
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("***** Lista de fornecedores: *****");
            ListaFornecedoresByCode();

            Console.WriteLine("\nInforme o codigo do fornecedor que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;
            Console.Clear();

            do
            {
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CNPJ: {fornecedor.CGCCPF} | Tipo de fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("\nQual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CNPJ | 03 - Tipo de fornecedor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CNPJ:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        ListaTipoFornecedor();
                        Console.WriteLine("\nInforme um novo Tipo de fornecedor:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;                    
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            var fornec = Program.Mock.ListaFornecedores.Find(r => r.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(fornec);
            Program.Mock.ListaFornecedores[index] = fornec;
        }

        public void Excluir()
        {
            Console.Clear();

            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("***** Lista de fornecedores *****");
            ListaFornecedoresByCode();

            Console.WriteLine("\nInforme o codigo do fornecedor que deseja excluir:");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            Program.Mock.ListaFornecedores.Remove(fornecedor);
            Console.Clear();
            Console.WriteLine("Dados excluido com sucesso!");
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadLine();
        }

        private void ListaFornecedoresByCode()
        {
            Console.WriteLine("Codigo | Nome");
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"{fornecedor.CodigoFornecedor} | {fornecedor.Nome}");
            }
        }

        private void ListaTipoFornecedor()
        {
            string[] tiposFornecedores = { "Medicamentos Geral", "Medicamentos Importados", "Materiais de Limpeza", "Materiais Cirurgicos" };
            foreach (var tipo in tiposFornecedores)
            {
                Console.Write($"| {tipo} |");
            }
        }
    }
}
