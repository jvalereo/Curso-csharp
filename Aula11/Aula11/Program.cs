using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Curso Udemy - Aula11, Exercicio de fixação, 
             inserir dados, tipo , string ,int ,double*/
            //Jonas Valereo - Técnico em Infomática

            //Declarando as variaveis tipo, string, int, double;

            string nome;
            int quarto;
            double preco;

            /* Declarando o codigo entrada de dado no console, 
            método ReadLine, Conversão para string*/

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine();
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Número de quarto: " + quarto + " " + "quarto");
            Console.WriteLine("Valor do preço do produto: " + preco.ToString("F2",CultureInfo.InvariantCulture) + " " + "Reais" );

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama

        }
    }
}
