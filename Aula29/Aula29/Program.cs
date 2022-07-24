using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula29, estrutura condicional simples, tipo int
            //Jonas Valereo - Técnico em Informática 

            //Declarando a variavel tipo int

            int hora;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a hora!!!");
            hora = int.Parse(Console.ReadLine());

            //Declarando estrutura condicional simples

            if (hora < 12)
            {
                Console.WriteLine("Bom dia ");
            }

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
