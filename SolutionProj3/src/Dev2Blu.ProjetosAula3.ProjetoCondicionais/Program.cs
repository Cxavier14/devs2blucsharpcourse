using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }

        static void Exercicio2e2()
        {
            int num1, num2, num3, num4;
            int menorValor = 99999999;

            Console.WriteLine("Informa o menor entre quatro valores!");

            Console.Write("Informe o primeiro valor: ");
            string num1Str = Console.ReadLine();
            Int32.TryParse(num1Str, out num1);

            Console.Write("Informe o segundo valor: ");
            string num2Str = Console.ReadLine();
            Int32.TryParse(num2Str, out num2);

            Console.Write("Informe o terceiro valor: ");
            string num3Str = Console.ReadLine();
            Int32.TryParse(num3Str, out num3);

            Console.Write("Informe o quarto valor: ");
            string num4Str = Console.ReadLine();
            Int32.TryParse(num4Str, out num4);

            if (num1 < menorValor)
            {
                menorValor = num1;
            }
            if (num2 < menorValor)
            {
                menorValor = num2;
            }
            if (num3 < menorValor)
            {
                menorValor = num3;
            }
            if (num4 < menorValor)
            {
                menorValor = num4;
            }

            Console.WriteLine($"O menor valor é {menorValor}");
        }

        static void Exercicio2()
        {
            int num1, num2, num3, num4;

            Console.WriteLine("Informa o menor entre quatro valores!");

            Console.Write("Informe o primeiro valor: ");
            string num1Str = Console.ReadLine();
            Int32.TryParse(num1Str, out num1);

            Console.Write("Informe o segundo valor: ");
            string num2Str = Console.ReadLine();
            Int32.TryParse(num2Str, out num2);

            Console.Write("Informe o terceiro valor: ");
            string num3Str = Console.ReadLine();
            Int32.TryParse(num3Str, out num3);

            Console.Write("Informe o quarto valor: ");
            string num4Str = Console.ReadLine();
            Int32.TryParse(num4Str, out num4);

            if (num1 < num2 &&
                num1 < num3 &&
                num1 < num4)
            {
                Console.WriteLine($"Valor 1 ({num1} é o menor)");
            }
            else if (num2 < num3 &&
                      num2 < num4)
            {
                Console.WriteLine($"Valor 2 ({num2} é o menor)");
            }
            else if (num3 < num4)
            {
                Console.WriteLine($"Valor 3 ({num3} é o menor)");
            }
            else
            {
                Console.WriteLine($"Valor 4 ({num4} é o menor)");
            }
        }

        static void Exercicio1()
        {
            int num1, num2;

            Console.WriteLine("Informa o maior entre dois valores!");

            Console.Write("Informe o primeiro valor: ");
            string num1Str = Console.ReadLine();
            Int32.TryParse(num1Str, out num1);

            Console.Write("Informe o segundo valor: ");
            string num2Str = Console.ReadLine();
            Int32.TryParse(num2Str, out num2);

            if (num1 > num2)
            {
                Console.WriteLine($"O maior valor é: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"O maior valor é: {num2}");
            }
            else
            {
                Console.WriteLine("Os valores são iguais!");
            }
        }

        static void Exemplo1()
        {
            string textoFormatado;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("|***** Bem vindo ao Programa SysSchool *****|\n\n");

            Console.Write("Informe o nome do candidato: ");
            nomeCandidato = Console.ReadLine();

            Console.Write("Informe a idade do candidato: ");
            string idadeSTR = Console.ReadLine();

            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Idade!");
                return;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeSTR);
            }

            Console.Write("Informe a nota do candidato: ");
            string notaSTR = Console.ReadLine();

            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Nota!");
                return;
            }
            else
            {
                notaCandidato = Int16.Parse(notaSTR);
            }

            // Formatação saida de dados
            textoFormatado = $"Candidato: {nomeCandidato}\n";
            textoFormatado += $"Idade: {idadeCandidato}";

            // se é maior de idade
            if (idadeCandidato < 18)
            {
                textoFormatado += "(Menor de idade)\n";
            }
            else
            {
                textoFormatado += "(Maior de idade)\n";
            }

            textoFormatado += $"Nota Final: {notaCandidato}\n\n";

            // se aprovado ou reprovado
            if (notaCandidato > 5)
            {
                textoFormatado += @"***************** 
*** Aprovado! ***
*****************";
            }
            else
            {
                textoFormatado += "| Reprovado! :´( |";
            }

            Console.WriteLine(textoFormatado);
        }
    }
}