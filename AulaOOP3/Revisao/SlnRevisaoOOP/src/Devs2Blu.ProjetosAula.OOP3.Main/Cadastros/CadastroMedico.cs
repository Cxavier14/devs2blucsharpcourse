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
        }

        public void Cadastrar()
        {
            Console.Clear();
            //Program.Mock.ListaMedicos.Add(novoMedico);
            Console.WriteLine("Em construção!");
        }

        public void Alterar()
        {
            Console.Clear();
            Console.WriteLine("Em construção!");
        }

        public void Excluir()
        {
            Console.Clear();
            Console.WriteLine("Em construção!");
        }
    }
}
