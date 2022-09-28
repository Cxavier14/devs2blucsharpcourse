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
        }

        public void Cadastrar()
        {
            Console.Clear();
            //Program.Mock.ListaRecepcionistas.Add(novaRecepcionista);
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
