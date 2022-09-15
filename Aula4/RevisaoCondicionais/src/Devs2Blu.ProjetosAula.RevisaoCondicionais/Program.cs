using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Devs2Blu.ProjetosAula.RevisaoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int opcao;
            do
            {
                Console.WriteLine("Seja Bem-vindo ao programa Locão!\n\n");
                Console.WriteLine("Escolha o programa desejado:");
                Console.WriteLine("1 - Exemplo 1 ** Mostrar o maior entre 2 valores");
                Console.WriteLine("2 - Exemplo 2 ** Mostra 3 valores em ordem crescente");
                Console.WriteLine("3 - Questão 3 ** Mostra se o numero é impar");
                Console.WriteLine("4 - Questão 4 ** Lista de compras");
                Console.WriteLine("5 - Questão 5 ** Se tem idade para votar");
                Console.WriteLine("6 - Exemplo 4 ** Se pode se aposentar");
                Console.WriteLine("7 - Questão 6 ** Senha para acesso ao sistema");
                Console.WriteLine("8 - Exemplo 3 ** Se maior de idade, acesso ao sistema");
                Console.WriteLine("9 - Exercicio 1 ** Valor para compra de maçã");
                Console.WriteLine("10 - Exercicio 2 ** Saiba seu peso ideal");
                Console.WriteLine("11 - Exercicio 3 ** poligono + area");
                Console.WriteLine("----------------");
                Console.WriteLine("0 - Sair");
                string optStr = Console.ReadLine();
                Int32.TryParse(optStr, out opcao);

                if (opcao == 1)
                {
                    Exemplo1();
                }
                else if (opcao == 2)
                {
                    Exemplo2();
                }
                else if (opcao == 3)
                {
                    Questao3();
                }
                else if (opcao == 4)
                {
                    Questao4();
                }
                else if (opcao == 5)
                {
                    Questao5();
                }
                else if (opcao == 6)
                {
                    Exemplo4();
                }
                else if (opcao == 7)
                {
                    Questao6();
                }
                else if (opcao == 8)
                {
                    Exemplo3();
                }
                else if (opcao == 9)
                {
                    Exercicio1();
                }
                else if (opcao == 10)
                {
                    Exercicio2();
                }
                else if (opcao == 11)
                {
                    Exercicio3();
                }
                else if (opcao == 0)
                {
                    Console.WriteLine("Muito grato. Volte Sempre! =D ");
                }
            } while (opcao != 0);
        }

        static void Exemplo4()
        {
            Console.Clear();
            /*
             * Verificar se a pessoa pode se aposentar
             * Tempo de Trabalho > 25 anos
             * OU
             * Idade > 65
             */
            int idade, tempoTrabalho;

            Random rd = new Random();

            idade = rd.Next(50, 80);
            tempoTrabalho = rd.Next(15, 40);

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Tempo de Trabalho: {tempoTrabalho}");

            if ((idade == 65) ||
                (tempoTrabalho > 25))
            {
                Console.WriteLine("Pessoa pode se aposentar!");
            }
            else
            {
                Console.WriteLine("Lamentamos, mas ainda não pode se aposentar.");
            }

        }
        static void Exemplo3()
        {
            Console.Clear();
            int idade;
            bool permissao;
            string nome;

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            string inputIdade = Console.ReadLine();
            Int32.TryParse(inputIdade, out idade);

            permissao = (idade >= 18) ? true : false;

            /*
             * Mesmo exemplo de cima. 
             * Usando concatenação de string e variável como valor
             * 
             * string texto = "Valor: ", textoDinamico = "Qualquer coisa";
             * texto += (idade >= 18) ? textoDinamico : "Fail!";
             *
             *   var qualquer = (a > b && c > a) ? true : false;
             */
            if (!permissao)
            {
                Console.WriteLine($"Seja bem-vindo(a), {nome}! (+18)");
            }
            else
            {
                Console.WriteLine("Você não pode entrar. Idade menor de 18 anos.");
            }

        }

        static void Exemplo1()
        {
            // Limpa o Console
            Console.Clear();

            Console.WriteLine("***** Programa Exemplo 1  *****");
            Console.WriteLine("***** Gerar 2 Números Aleatórios (1 - 100) *****");
            Console.WriteLine("***** Mostrar o maior entre eles *****");
            int numero1, numero2;

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);

            Console.WriteLine($"Número 1 = {numero1}.");
            Console.WriteLine($"Número 2 = {numero2}.");

            if (numero1 < numero2)
            {
                Console.WriteLine($"Número 1 é o maior. Numero1 = {numero1}");
            }
            else if (numero2 < numero1)
            {
                Console.WriteLine($"Número 2 é o maior. Numero1 = {numero2}");
            }
            else
            {
                Console.WriteLine($"Os números são iguais! Números = {numero1}");
            }
        }

        static void Exemplo2()
        {
            // Limpa o Console
            Console.Clear();

            Console.WriteLine("***** Programa Exemplo 2 *****");
            Console.WriteLine("***** Gerar 3 número aleatórios *****");
            Console.WriteLine("***** Escrevê-los em ordem crescente *****");
            int numero1, numero2, numero3;
            string formataSaida = "";

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);
            numero3 = rd.Next(1, 100);

            if (numero1 < numero2 &&
                numero1 < numero3)
            {
                formataSaida += $"{numero1}, ";
                if (numero2 < numero3)
                {
                    formataSaida += $"{numero2}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero2}";
                }
            }
            else if (numero2 < numero1 &&
                   numero2 < numero3)
            {
                formataSaida += $"{numero2}, ";
                if (numero1 < numero3)
                {
                    formataSaida += $"{numero1}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero1}";
                }
            }
            else
            {
                formataSaida += $"{numero3}, ";
                if (numero1 < numero2)
                {
                    formataSaida += $"{numero1}, {numero2}";
                }
                else
                {
                    formataSaida += $"{numero2}, {numero1}";
                }
            }

            Console.WriteLine($"Ordem crescente: {formataSaida}");
        }

        static void Questao6()
        {
            Console.Clear();
            const string SENHA_SISTEMA = "1234";
            const string MSG_ACESSO_PERM = "Acesso Concedido!";
            const string MSG_ACESSO_NEG = "Acesso Negado!";
            string senhaUsuario;

            Console.WriteLine("Informe a senha para acessar o sistema:");
            senhaUsuario = Console.ReadLine();

            /*while (senhaUsuario != SENHA_SISTEMA)
            {
                Console.WriteLine($"{MSG_ACESSO_NEG} Tente novamente:");
                senhaUsuario = Console.ReadLine();
            }
            Console.WriteLine(MSG_ACESSO_PERM);
            */

            if (senhaUsuario.Equals(SENHA_SISTEMA))
            {
                Console.WriteLine(MSG_ACESSO_PERM);
            }
            else
            {
                Console.WriteLine(MSG_ACESSO_NEG);
            }
        }
        static void Questao5()
        {
            Console.Clear();
            int idade, anoNascimento;

            Console.WriteLine("Informe o ano de seu nascimento:");
            string anoSTR = Console.ReadLine();
            Int32.TryParse(anoSTR, out anoNascimento);

            idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Pode Votar!");
            }
            else
            {
                Console.WriteLine("Não pode votar!");
            }
        }
        static void Questao4()
        {
            Console.Clear();
            string codigoProduto;
            Console.WriteLine("Escolha um produto:");
            Console.WriteLine("001 - Arroz");
            Console.WriteLine("002 - Feijão");
            Console.WriteLine("003 - Farinha");

            codigoProduto = Console.ReadLine();

            if (codigoProduto.Equals("001"))
            {
                Console.WriteLine("Produto escolhido foi Arroz");
            }
            else
            if (codigoProduto.Equals("002"))
            {
                Console.WriteLine("Produto escolhido foi Feijão");
            }
            else
            if (codigoProduto.Equals("003"))
            {
                Console.WriteLine("Produto escolhido foi Farinha");
            }
            else
            {
                Console.WriteLine("Produto Diverso.");
            }
        }

        static void Questao3()
        {
            Console.Clear();
            int numero;
            Random rd = new Random();

            numero = rd.Next(1, 100);

            if (!(numero - numero / 2 * 2 == 0))
            {
                Console.WriteLine($"O Número Gerado {numero} é ÍMPAR!");
            }
            else
            {
                Console.WriteLine($"O Número Gerado {numero} é PAR!");
            }
        }

        static void Exercicio1()
        {
            Console.Clear();

            int quantidade;
            const double VALOR_DUZIA_OU_MAIS = 0.25;
            const double VALOR_MENOS_DUZIA = 0.30;
            Console.WriteLine("Informe Quantas maçãs você deseja comprar:");
            string inputQntd = Console.ReadLine();
            Int32.TryParse(inputQntd, out quantidade);

            if (quantidade >= 12)
            {
                //0,25
                double result = quantidade * VALOR_DUZIA_OU_MAIS;
                Console.WriteLine($"O valor a ser pago sera: R$ {result.ToString("F2")}");
            }
            else
            {
                //0,30
                double result = quantidade * VALOR_MENOS_DUZIA;
                Console.WriteLine($"O valor a ser pago sera: R$ {result.ToString("F2")}");
            }
        }

        static void Exercicio2()
        {
            Console.Clear();

            int sexo;
            double altura;
            Console.WriteLine("Informe seu sexo:");
            Console.WriteLine("1 - Feminino / 2 - Masculino");
            string sexoInput = Console.ReadLine();
            Console.WriteLine("Informe sua altura (M,CM)");
            string alturaInput = Console.ReadLine();

            Int32.TryParse(sexoInput, out sexo);
            Double.TryParse(alturaInput, out altura);

            if (sexo.Equals(1))
            {
                double result = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é: {result.ToString("F2")}");
            }
            else if (sexo.Equals(2))
            {
                double result = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é: {result.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Valor não existente!");
            }
        }

        static void Exercicio3()
        {
            /*
             Escreva um programa para ler o número de lados de um polígono regular
            e a medida do lado (em cm). Calcular e imprimir o seguinte:
            − Se o número de lados for igual a 3 escrever TRIÂNGULO e o valor da
            área
            − Se o número de lados for igual a 4 escrever QUADRADO e o valor da
            sua área.
            − Se o número de lados for igual a 5 escrever PENTÁGONO.
             */
            int ladosQtd, medida;
            Console.WriteLine("Informe quantos lados tem o poligono:");
            Console.WriteLine("** 3 **\n** 4 **\n** 5 **");
            string ladosInput = Console.ReadLine();
            Int32.TryParse(ladosInput, out ladosQtd);
            Console.WriteLine("Agora informe a medida do poligono:");
            string medidaInput = Console.ReadLine();
            Int32.TryParse(medidaInput, out medida);

            if (ladosQtd.Equals(3))
            {
                double altura = (medida * Math.Sqrt(3.0)) / 2;
                double result = (medida * altura) / 2;
                Console.WriteLine($"A area do triangulo é: {result.ToString("F2")}");
            }
            else if (ladosQtd.Equals(4))
            {
                double result = medida * medida;
                Console.WriteLine($"A area do quadrado é: {result.ToString("F2")}");
            }
            else if (ladosQtd.Equals(5))
            {

            }
            else if (ladosQtd)
        }

    }
}
