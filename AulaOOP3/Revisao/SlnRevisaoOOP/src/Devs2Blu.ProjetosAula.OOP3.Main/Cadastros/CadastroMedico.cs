﻿using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {
        public CadastroMedico()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
                Console.WriteLine("***** Cadastro de Medico *****");
                Console.WriteLine("----- 1 - Lista de Medico -----");
                Console.WriteLine("----- 2 - Cadastro de Medico -----");
                Console.WriteLine("----- 3 - Alterar Medico -----");
                Console.WriteLine("----- 4 - Excluir Medico -----");
                Console.WriteLine("-----------------------");
                Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarMedico();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarMedico();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirMedico();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarMedicos()
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

        public void CadastrarMedico()
        {
            Console.WriteLine("Em construção!");
        }

        public void AlterarMedico()
        {
            Console.WriteLine("Em construção!");
        }

        public void ExcluirMedico()
        {
            Console.WriteLine("Em construção!");
        }
    }
}
