using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula09, inserir dados, tipo int, char, double,concatenação
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis, int, char, double

            int num;
            char n;
            double nume;

            /*Declarando as variaveis, entrada de dados,conversão para 
              para string , método ReadLine*/

            num = int.Parse(Console.ReadLine());
            n = char.Parse(Console.ReadLine());
            nume = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("Resposta do Resultado: ");
            Console.WriteLine();
            Console.WriteLine("Valo numero inteiro: " + num);
            Console.WriteLine("Valor da letra " + n);
            Console.WriteLine("Valor do numero " + nume.ToString("F2",CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama

        }
    }
}
