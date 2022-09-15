using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Bem vindo ***");
            Console.WriteLine("Escolha um programa:");
            Console.WriteLine("1 - Codigo do produto");
            Console.WriteLine("2 - Fruta");
            Console.WriteLine("3 - Comprar um carro");
            Console.WriteLine("4 - Jogo do 21");
            Console.WriteLine("5 - Calculadora");
            string input = Console.ReadLine();
            int opcao;
            Int32.TryParse(input, out opcao);

            if (opcao.Equals(1))
            {
                ExemploSwitch1();
            }
            else if (opcao.Equals(2))
            {
                ExercicioSwitch1();
            }
            else if (opcao.Equals(3))
            {
                ExercicioSwitch2();
            }
            else if (opcao.Equals(4))
            {
                ExercicioSwitch3();
            }
            else if (opcao.Equals(5))
            {
                ExercicioCalculadora();
            }
        }

        static void ExemploSwitch1()
        {
            Console.Clear();
            string codigo;

            Console.WriteLine("Informe um codigo para ver a descrição:");
            Console.WriteLine("- A23");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            const string A21 = "A21";
            const string A22 = "A22";
            const string A23 = "A23";
            const string A24 = "A24";
            const string A35 = "A35";
            const string Z16 = "Z16";

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case A21:
                case A22:
                case A23:
                case A24:
                    Console.WriteLine("A23: Materiais.");
                    break;
                case A35:
                    Console.WriteLine("A35: Produtos Perecíveis.");
                    break;
                case Z16:
                    Console.WriteLine("Z16: Produtos Químicos.");
                    break;

                default:
                    Console.WriteLine("Produto Não Cadastrado.");
                    break;
            }
        }

        static void ExercicioSwitch1()
        {
            Console.Clear();

            Console.WriteLine("Informe qual fruta você deseja:");
            Console.WriteLine("Maçã");
            Console.WriteLine("Kiwi");
            Console.WriteLine("Melancia");
            string fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case "MAÇÃ":
                    Console.WriteLine("Não vendemos maçã aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui esta, são R$ 3,00 o kilo");
                    break;
                default:
                    Console.WriteLine("Fruta não encontrada");
                    break;
            }
        }

        static void ExercicioSwitch2()
        {
            Console.Clear();

            Console.WriteLine("Informe qual automovel você deseja:");
            Console.WriteLine("Hatch");
            Console.WriteLine("Sedan");
            Console.WriteLine("Motocicleta");
            Console.WriteLine("Caminhonete");
            string escolha = Console.ReadLine();

            switch (escolha.ToUpper())
            {
                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case "SEDAN":
                case "MOTOCICLETA":
                case "CAMINHONETE":
                    Console.WriteLine("Tem certeza que não prefere este modelo?");
                    break;
                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }

        static void ExercicioSwitch3()
        {
            Console.Clear();

            const int PT7 = 10;
            const int PT14 = 20;
            const int PT21 = 30;
            const int PT1a6 = 1;
            const int PT8a13 = 5;
            const int PT15a20 = 6;

            Console.WriteLine("*** Bem vindo ao jogo do 21 ***");
            Console.WriteLine("Escolha um numero entre 1 e 20:");

            int escolhaUsuario;
            Int32.TryParse(Console.ReadLine(), out escolhaUsuario);

            Random rd = new Random();
            int escolhaPc = rd.Next(1, 20);
            int resultadoOponente = rd.Next(1, 20) + escolhaPc;
            
            int resultadoUsuario = escolhaUsuario + escolhaPc;

            int pontosUsuario = 0;
            int pontosOponente = 0;

            switch (resultadoUsuario)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontosUsuario = PT1a6;
                    break;
                case 7:
                    pontosUsuario = PT7;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontosUsuario = PT8a13;
                    break;
                case 14:
                    pontosUsuario = PT14;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontosUsuario = PT15a20;
                    break;
                case 21:
                    pontosUsuario = PT21;
                    break;
            }

            switch (resultadoOponente)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontosOponente = PT1a6;
                    break;
                case 7:
                    pontosOponente = PT7;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontosOponente = PT8a13;
                    break;
                case 14:
                    pontosOponente = PT14;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontosOponente = PT15a20;
                    break;
                case 21:
                    pontosOponente = PT21;
                    break;
            }

            Console.WriteLine($"escolha do oponente: {resultadoOponente}");
            Console.WriteLine($"O numero sorteado pelo pc: {escolhaPc}");
            Console.WriteLine($"Pontos do usuario: {pontosUsuario} pontos");
            Console.WriteLine($"Pontos do oponente: {pontosOponente} pontos");
        }

        static void ExercicioCalculadora()
        {
            Console.Clear();

            const string SOMA = "+";
            const string SUBTRACAO = "-";
            const string MULTIPLICACAO = "x";
            const string DIVISAO = "%";

            Console.WriteLine("** Qual operação você deseja fazer?");
            Console.WriteLine(" + ");
            Console.WriteLine(" - ");
            Console.WriteLine(" x ");
            Console.WriteLine(" % ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case SOMA:
                    Console.WriteLine("Soma escolhida");
                    break;
                case SUBTRACAO:
                    Console.WriteLine("Subtração escolhida");
                    break;
                case MULTIPLICACAO:
                    Console.WriteLine("Multiplicação escolhida");
                    break;
                case DIVISAO:
                    Console.WriteLine("Divisão escolhida");
                    break;
                default:
                    Console.WriteLine("Operação não encontrada");
                    break;
            }
        }
    }
}
