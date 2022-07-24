using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy -  Aula13, Calculo matematicos , tipo double
            //Jonas Valereo - Técnico em Infomática

            //Declarando as variaveis tipo double

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            //Declarando as variaveis , raiz quadrada

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Resposta da Raiz Quadrada: ");
            Console.WriteLine();
            Console.WriteLine("A raiz quadrada de " + x +  " = " + A);
            Console.WriteLine(" A raiz quadrada de " + y + " = " + B);
            Console.WriteLine("A raiz quadrada de 25 = " + C);
            Console.WriteLine();

            //Declarando as variaveis , raiz quadrada potencia 

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Resposta da Raiz Potencia: ");
            Console.WriteLine();
            Console.WriteLine(x  + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elavado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);
            Console.WriteLine();

            //Declarando as variaveis , valor absoluto

            A = Math.Abs(y);
            B = Math.Abs(z);

            //imprimir saida de dados no console, método WhriteLine, concatenação
            Console.WriteLine("Resposta da Raiz Absoluta: ");
            Console.WriteLine();
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);
            Console.WriteLine();

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama

        }
    }
}
