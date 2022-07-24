using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Curso Udemy - Aula02, escreve conteudo de variavel , tipo double
            , int, string, char , concatenção */
            //Jonas Valereo - Técnica em informática

            //Declarando a variaveis tipo double, int, string, char

            double x = 10.41742;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine();
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais!");

            //imprimir saida de dados no console, método WhriteLine

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine();

            //imprimir saida de dados no console, método WhriteLine, CultureInfo.InvariantCulture

            Console.WriteLine();
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //imprimir saida de dados no console, método WhriteLine,concatenção,CultureInfo.InvariantCulture

            Console.WriteLine();
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O Valor do troco é " + x + " Reais ");
            Console.WriteLine("O Valor do troco é " + x.ToString("F2") + " Reais ");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
