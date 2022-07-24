using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula25 ,URI 1006, Calcula a media ponderada,tipo double
            //Jonas valereo - Técnico em informática

            //Declarando as variaveis tipo double

            double A, B, C, PA, PB, PC, SOMA, MEDIA;


            //Declarando valores as variaveis A, B, C, Soma

            PA = 2;
            PB = 3;
            PC = 5;

            SOMA = PA + PB + PC;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a 1 nota: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2 nota: ");
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 3 nota: ");
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Declarando a variavel media ponderada

            MEDIA = (PA * A + PB * B + PC * C ) / SOMA;

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
