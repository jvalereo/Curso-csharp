using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula05, area do trapezio, tip float
            //Jonas valereo - Técnico em informática

           //Declarando a variavel tip float

            float b, B, h, area;

            b = 6.0f;
            B = 8.0f;
            h = 5.0f;

            //Declarando a variavel area

            area = (b + B) / 2 * h;

            //imprimir saida de dados no console, método WhriteLine

            Console.WriteLine("O valor da area: " + area);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
