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
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {

        }

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("***** Cadastro de Medico *****");
            Console.WriteLine("----- 1 - Lista de Medicos -----");
            Console.WriteLine("----- 2 - Cadastro de Medico -----");
            Console.WriteLine("----- 3 - Alterar Medico -----");
            Console.WriteLine("----- 4 - Excluir Medico -----");
            Console.WriteLine("-----------------------");
            Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("-----------------------------------\n");
            }
            Console.WriteLine("Pressione Enter para voltar ao menu");
            Console.ReadLine();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Int32 crm;

            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Informe o CRM:");
            Int32.TryParse(Console.ReadLine(), out crm);

            Console.WriteLine("*** Lista de Especialidades ***");
            ListaEspecialidades();
            Console.WriteLine("\nInforme a especialidade:");
            string especialidade = Console.ReadLine();

            Random rd = new Random();
            int codigo = rd.Next(1, 100) + DateTime.Now.Second;
            int codigoMedico = Int32.Parse($"{codigo}{rd.Next(1, 99)}");

            Program.Mock.ListaMedicos.Add(new Medico(codigoMedico, nome, cpf, crm, especialidade));
            Console.Clear();
            Console.WriteLine("Dados cadastrado com sucesso!");
            Console.WriteLine("Pressione Enter para voltar ao menu");
            Console.ReadLine();
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("***** Lista de medicos: *****");
            ListaMedicosByCode();

            Console.WriteLine("\nInforme o codigo da(o) medico que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;
            Console.Clear();

            do
            {
                Console.WriteLine($"Medico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | CRM: {medico.CRM} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("\nQual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - CRM | 04 - Especialidade | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("\nInforme um novo CRM:");
                        int crm;
                        Int32.TryParse(Console.ReadLine(), out crm);
                        medico.CRM = crm;
                        break;
                    case "04":
                        ListaEspecialidades();
                        Console.WriteLine("\nInforme uma nova especialidade:");
                        medico.Especialidade = Console.ReadLine();
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

            var medic = Program.Mock.ListaMedicos.Find(r => r.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(medic);
            Program.Mock.ListaMedicos[index] = medic;
        }

        public void Excluir()
        {
            Console.Clear();

            Medico medico;
            int codigoMedico;

            Console.WriteLine("***** Lista de medicos *****");
            ListaMedicosByCode();

            Console.WriteLine("\nInforme o codigo da(o) medico que deseja excluir:");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            Program.Mock.ListaMedicos.Remove(medico);
            Console.Clear();
            Console.WriteLine("Dados excluidos com sucesso!");
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadLine();
        }

        private void ListaMedicosByCode()
        {
            Console.WriteLine("Codigo | Nome");

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"{medico.CodigoMedico} | {medico.Nome}");                                
            }
        }

        private void ListaEspecialidades()
        {
            string[] especialidade = { "Clinico Geral", "Cardiologista", "Endocrinologista", "Neurologista", "Oftalmologista", "Pediatra" };
            foreach (var espc in especialidade)
            {
                Console.Write($"| {espc} | ");
            }
        }
    }
}
