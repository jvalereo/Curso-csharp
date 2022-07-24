using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula22 URI 1003, Calcule a soma de dois numero, tipo int
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo int

            int A, B, SOMA;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o 1 número: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o  2 número: ");
            B = int.Parse(Console.ReadLine());

            //Declarando a variavel soma

            SOMA = A + B;

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("SOMA = " + SOMA);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
 
        }
    }
}
