using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy  - Aula14 , Equação do 2º grau, tipo double
            //Jonas Valereo - Técnico em Infomática

            //Declarando as variveis tipo double

            double a, b, c, delta, x1, x2;

            a = 1;
            b = 5;
            c = 0;

            //Declarando a variavel delta

            delta = Math.Pow(4.0 , 2.0) - 4*a*c;

            //Declarando as variaveis x1 e x2 

            x1 = (- b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * b);

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Os valores da Raiz de X1 e X2 é: ");
            Console.WriteLine();
            Console.WriteLine("O valor de x1: " +  x1);
            Console.WriteLine("O valor de x2: " + x2);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programas

        }
    }
}
