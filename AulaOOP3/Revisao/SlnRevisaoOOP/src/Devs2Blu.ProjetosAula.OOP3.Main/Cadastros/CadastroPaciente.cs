﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public CadastroPaciente()
        {

        }

        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
                Console.WriteLine("***** Cadastro de Pacientes *****");
                Console.WriteLine("----- 1 - Lista de Pacientes -----");
                Console.WriteLine("----- 2 - Cadastro de Paciente -----");
                Console.WriteLine("----- 3 - Alterar Paciente -----");
                Console.WriteLine("-----------------------");
                Console.WriteLine("----- 0 - Voltar Para o Menu Principal -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarPaciente();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarPaciente();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirPaciente();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarPacientes()
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

        public void CadastrarPaciente()
        {
            Console.Clear();
            //Program.Mock.ListaPacientes.Add(novoPaciente);
            Console.WriteLine("Em construção!");
        }

        public void AlterarPaciente()
        {
            Console.Clear();
            Console.WriteLine("Em construção!");
        }

        public void ExcluirPaciente()
        {
            Console.Clear();
            Console.WriteLine("Em construção!");
        }
    }
}
