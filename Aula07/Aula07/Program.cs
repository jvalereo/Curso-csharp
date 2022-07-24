using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula07 , entrada de dados , tipo string 
            //Jonas Valereo - Técnico em informática 

            //Declarando a variaveis 

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //imprimir saida de dados no console, método WhriteLine, 

            Console.WriteLine("Você digitou: ");
            Console.WriteLine();
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
