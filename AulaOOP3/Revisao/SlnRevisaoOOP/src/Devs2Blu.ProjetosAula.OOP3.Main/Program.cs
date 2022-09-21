using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
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
            Mock = new Mocks();
            ViewListPacientes();
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
