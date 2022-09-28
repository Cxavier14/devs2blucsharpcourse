using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }

        private void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("-----------------------------------\n");
            }
        }

        private void CadastrarPacientes(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }

        private void AlterarPacientes(Paciente paciente)
        {

        }

        private void ExcluirPacientes(Paciente paciente)
        {

        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("***** Cadastro de Pacientes *****");
            Console.WriteLine("----- 1 - Lista de Pacientes -----");
            Console.WriteLine("----- 2 - Cadastro de Paciente -----");
            Console.WriteLine("----- 3 - Alterar Paciente -----");
            Console.WriteLine("----- 4 - Excluir Paciente -----");
            Console.WriteLine("-----------------------");
            Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarPacientes();
        }

        public void Cadastrar()
        {
            Paciente paciente = new Paciente();
            CadastrarPacientes((Paciente)paciente);
        }

        public void Alterar()
        {
            Paciente paciente = new Paciente();
            AlterarPacientes((Paciente)paciente);
        }

        public void Excluir()
        {
            Paciente paciente = new Paciente();
            ExcluirPacientes((Paciente)paciente);
        }
        #endregion
    }
}
