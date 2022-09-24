using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            int opcao;
            Mock = new Mocks();
            do
            {
                Console.Clear();
                Console.WriteLine("***** Sistema de Gerencimento de Clínicas *****");
                Console.WriteLine("----- 10 - Cadastro de Pacientes -----");
                Console.WriteLine("----- 20 - Cadastro de Medicos -----");
                Console.WriteLine("----- 30 - Cadastro de Recepcionista -----");
                Console.WriteLine("----- 40 - Cadastro de Fornecedores -----");
                Console.WriteLine("----- 50 - Agenda -----");
                Console.WriteLine("----- 60 - Prontuario -----");
                Console.WriteLine("----- 70 - Financeiro -----");
                Console.WriteLine("-------------------------");
                Console.WriteLine("----- 0 - Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        CadastroPaciente ModuloCadastroPaciente = new CadastroPaciente();
                        ModuloCadastroPaciente.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedico ModuloCadastroMedico = new CadastroMedico();
                        ModuloCadastroMedico.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionista ModuloCadastroRecepcionista = new CadastroRecepcionista();
                        ModuloCadastroRecepcionista.MenuCadastro();
                        break;
                    default:
                        break;
                }

                
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public static void ViewListPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Mock.ListaPacientes)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Nome: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"Nome: {paciente.CGCCPF}");
                Console.WriteLine($"Nome: {paciente.Convenio}");
                Console.WriteLine($"Nome: {paciente.TipoPessoa}");
                Console.WriteLine("-----------------------------------\n");
            }
        }
    }
}
