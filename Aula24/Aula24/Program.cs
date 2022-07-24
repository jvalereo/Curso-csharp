using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula24, URI 1005, Calculo de media ponderada, tipo double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            double A, B ,PA, PB, SOMA, MEDIA;

            PA = 3.5;
            PB = 7.5;

            SOMA = PA + PB;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a 1 nota: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2 nota: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando a variavel da media ponderada de A e B

            MEDIA = (PA * A +  PB * B) / SOMA;

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
