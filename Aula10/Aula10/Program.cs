using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {

            //Curso Udemy - Aula10, inserir dados,
            //tipo, string, int, char, double, vetor, concatenação
            //Jonas Valereo - Técnico em Informática 

            //Declarando a variavel j do vetor 
         
            string[] j = Console.ReadLine().Split(' ');

            /*Declarando o codigo entrada de dado no console, 
              método ReadLine, string, vetor, split*/

            string nome  =  j[0];
            int numero = int.Parse(j[1]);
            char n = char.Parse(j[2]);
            double num = double.Parse(j[3]);
            Console.WriteLine();

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Resposta: ");
            Console.WriteLine();
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Numero: " + numero);
            Console.WriteLine("Caracterer: " + n);
            Console.WriteLine("Numero: " + num);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
