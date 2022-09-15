using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula.Aula6Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;

            do
            {
                Console.WriteLine("\nInforme um dos códigos Abaixo");
                Console.WriteLine("1 - Exemplo1 ** 0 p/sair");
                Console.WriteLine("2 - Exemplo2 ** 0 p/sair");
                Console.WriteLine("3 - Exercicio1 ** mostra impares");
                Console.WriteLine("4 - Exercicio2 ** mostra pares");
                Console.WriteLine("5 - Exercicio3 ** impares e pares(separados)");
                Console.WriteLine("6 - Exercicio4 ** media alunos");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exercicio1();
                        break;
                    case 4:
                        Exercicio2();
                        break;
                    case 5:
                        Exercicio3();
                        break;
                    case 6:
                        Exercicio4();
                        break;
                    default:
                        break;
                }

            } while (controle > 0);
        }

        static void Exemplo1()
        {
            int controle = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }

        static void Exemplo2()
        {
            Console.WriteLine("Ex.: 2");
        }

        static void Exercicio1()
        {
            Console.Clear();

            Console.WriteLine("Exemplo 2 - Mostra impares(1 - 100)");
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"[{i}] ");
                }
                i++;
            }
        }

        static void Exercicio2()
        {
            Console.Clear();

            Console.WriteLine("Exemplo 3 - Mostra pares(1 - 100)");
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"[{i}]");
                }
                i++;
            }
        }

        static void Exercicio3()
        {
            Console.Clear();

            int finish;
            Console.WriteLine("Exemplo 4 - pares e inpares(separados)");
            Console.WriteLine("Informe até qual valor sera contado:");
            Int32.TryParse(Console.ReadLine(), out finish);

            int i = 1;
            Console.WriteLine("Impares\t\tPares");
            while (i <= finish)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"[{i}] ");
                }
                else
                {
                    Console.Write($"\t\t[{i}] \n");
                }
                i++;
            }
        }

        static void Exercicio4()
        {
            Console.Clear();

            int input;
            int QtdAlunos;
            int somaNotas = 0;
            Console.WriteLine("Informe a quantidade de alunos:");
            Int32.TryParse(Console.ReadLine(), out QtdAlunos);

            int i = 1;
            while (i <= QtdAlunos)
            {
                Console.WriteLine($"Informe a nota do {i}° aluno:");
                Int32.TryParse(Console.ReadLine(), out input);
                somaNotas += input;
                i++;
            }

            int media = somaNotas / QtdAlunos;
            Console.WriteLine($"A media aritmética é: {media}");
        }
    }
}
