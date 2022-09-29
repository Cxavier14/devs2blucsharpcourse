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
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("***** Cadastro de Recepcionista *****");
            Console.WriteLine("----- 1 - Lista de Recepcionista -----");
            Console.WriteLine("----- 2 - Cadastro de Recepcionista -----");
            Console.WriteLine("----- 3 - Alterar Recepcionista -----");
            Console.WriteLine("----- 4 - Excluir Recepcionista -----");
            Console.WriteLine("-----------------------");
            Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("-----------------------------------\n");
            }
            Console.Write("Pressione Enter para voltar ao menu");
            Console.ReadLine();
        }

        public void Cadastrar()
        {
            Console.Clear();

            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("*** Lista de Setores: ***");
            ListaSetores();
            Console.WriteLine("\nInforme o setor:");
            string setor = Console.ReadLine();

            Random rd = new Random();
            int codigo = rd.Next(1, 100) + DateTime.Now.Second;
            int codigoRecepcionista = Int32.Parse($"{codigo}{rd.Next(1, 99)}");
            
            Program.Mock.ListaRecepcionistas.Add(new Recepcionista(codigoRecepcionista, nome, cpf, setor));
            Console.WriteLine("Dados cadastrado com sucesso!");
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("***** Lista de recepcionistas: *****");
            ListaRecepcionistaByCode();

            Console.WriteLine("\nInforme o codigo da(o) recepcionista que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;
            Console.Clear();


            do
            {
                Console.WriteLine($"Recepcionista: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("\nQual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Setor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        ListaSetores();
                        Console.WriteLine("\nInforme um novo setor:");
                        recepcionista.Setor = Console.ReadLine();
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
            
            var recep = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(recep);
            Program.Mock.ListaRecepcionistas[index] = recep;            
        }

        public void Excluir()
        {
            Console.Clear();

            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("***** Lista de recepcionistas *****");
            ListaRecepcionistaByCode();

            Console.WriteLine("\nInforme o codigo da(o) recepcionista que deseja excluir:");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
            Console.Clear();
            Console.WriteLine("Dados excluido com sucesso!");
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadLine();
        }


        private void ListaSetores()
        {
            string[] setoresRecepcionista = { "Ambulatório", "Exames", "Internação", "Centro Cirúrgico", "UTI", "Pronto Socorro", "Serviços Assistenciais" };
            foreach (var setor in setoresRecepcionista)
            {
                Console.Write($"| {setor} | ");
            }
        }
        
        private void ListaRecepcionistaByCode()
        {
            Console.WriteLine("Codigo | Nome");
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"{recepcionista.CodigoRecepcionista} | {recepcionista.Nome}");                
            }
        }
    }
}
