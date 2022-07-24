using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula17, Calculo matemático, tipo int
            //Jonas Valereo - Técnico em Informátia

            //Declarando as variaveis , tipo int

            int a;
            int b;
            int x;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite 1º número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2º número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declarando a varivel resultado

            x = a + b;

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("O Resultado é: " + x);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
