using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula26
{
    class Program
    {
        static void Main(string[] args)
        {

            //Curso Udemy - Aula 26, URI, calculo de diferença , tipo int
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            int A, B, C, D, DIFERENCA;


            //declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o 1 número: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 número: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3 número: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4 número: ");
            D = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //declarando a variavel diferença

            DIFERENCA = (A * B - C * D);

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("DIFERENÇA = " + DIFERENCA);

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
