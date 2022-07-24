using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula04 area do trapezio, tipo double
            //Jonas Valereo - Técnico em informática

            //Declarando as variaveis tipo double

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            //Declarando as variaveis area

            area = (b + B) / 2 * h;

            //imprimir saida de dados no console, método WhriteLine

            Console.WriteLine("O Valor da area: " + area);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
