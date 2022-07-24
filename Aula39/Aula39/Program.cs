using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula 39 - Curso Udemy Logica de Programação e C#
            //Inserindo dados, tipo double, usando estrutura condicional composta
            //Aula Equação do 2º grau
            //Jonas Valereo - Técnico em Informática 

            //declarando as variaveis do tipo double

            double a, b, c, delta, x1, x2;

            //declarando o vetor , comando split 

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //declarando  variavel delta

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            //declarando estrutura condicianal composta

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("impossivel Calcular");
            }
            else
            {
                x1 =(-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("X1 " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa
        }
    }
}
