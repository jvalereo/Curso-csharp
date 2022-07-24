using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula08, inserir dados, vetor, tipo string , concatenação
            //Jonas Valereo - Técnico em Informática 

            //Declarando o vetor e as variaveis

            string[] k = Console.ReadLine().Split(' ');

            string  p1 = k[0];
            string  p2 = k[1];
            string  p3 = k[2];
            string  p4 = k[3];

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Sua informações:");
            Console.WriteLine();
            Console.WriteLine("Você digitou: " + p1);
            Console.WriteLine("Você digitou: " + p2);
            Console.WriteLine("Você digitou: " + p3);
            Console.WriteLine("Você digitou: " + p4);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa 

        }
    }
}
