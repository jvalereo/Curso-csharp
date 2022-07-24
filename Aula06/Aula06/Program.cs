using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy -  Aula06, inserir dados, tipo int, double
            //Jonas valereo - Técnico em informática

            //Declarando as variaveis tipo int, double exemplo 1

            int a, b;
            double resultdo;

            a = 5;
            b = 2;

            //Declarando a variavel resultado

            resultdo = a / b;

            //imprimir saida de dados no console, método WhriteLines

            Console.WriteLine(resultdo);
            Console.WriteLine();

            /*Declarando as variaveis tipo int, double Casting conversão explicita de tipo
            para outro,exemplo 2 */

            int x, y;
            double result;

            x = 10;
            y = 15;

            //Declarando a variavel result

            result = (double) x / y;

            //imprimir saida de dados no console, método WhriteLine

            Console.WriteLine(result);
            Console.WriteLine();

            /*Declarando as variaveis tipo int, double Casting conversão explicita de tipo
           para outro,exemplo 2 */

            double f, h;
           
            f = 5.0f;
            h = f;

            //imprimir saida de dados no console, método WhriteLine

            Console.WriteLine(h);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
