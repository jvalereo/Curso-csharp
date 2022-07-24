using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula23 URI 1004, Calculo de produto simples, tipo int 
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo int

            int num1, num2, PROD;

            Console.WriteLine("Digite o 1 número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 número: ");
            num2 = int.Parse(Console.ReadLine());

            //Declarando a variavel prod

            PROD = num1 * num2;

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("PROD = " + PROD);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
