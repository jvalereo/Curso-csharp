using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula30, estrutura condicional composta , tipo int
            //Jonas Valereo - Técnico em Informática 

            //Declarando a variavel tipo int

            int hora;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a hora!!!");
            hora = int.Parse(Console.ReadLine());

            //Declarando estrutura condicional composta

            if (hora < 12)
            {

                Console.WriteLine("Bom dia");
            }
            else
            {
                Console.WriteLine("Boa tarde");
            }

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
