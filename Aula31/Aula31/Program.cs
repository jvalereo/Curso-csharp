using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - aula31, encadeamento de estrutura condiconal, tipo int
            //Jonas Valereo - Técnico em Informática

            //Declarando a variavel tipo int

            int hora;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a hora");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declarando encademaneto estrutura condicional composta

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
