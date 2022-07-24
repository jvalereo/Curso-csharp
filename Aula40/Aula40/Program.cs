using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula 40 - Curso Udemy Logica de Programação e C#
            //Inserindo dados, tipo double, usando estrutura condicional composta
            //Aula Saber que o número maior entre os três
            //Jonas Valereo - Técnico em Informática 

            //declarando as variavies do tipo int

            int num1, num2, num3;

            //declarando a variavel vetor, usando comand split

            string[] vetor = Console.ReadLine().Split(' ');

            num1 = int.Parse(vetor[0]);
            num2 = int.Parse(vetor[1]);
            num3 = int.Parse(vetor[2]);

            //declarando a estrutura condicional composta, tomada de descisão 

            if( num1 < num2 &&  num1 < num3 ){

                Console.WriteLine("MENOR: " + num1);
                
            }else if (num2 < num3)
            {
                Console.WriteLine("MENORr:  " + num2);
            }
            else
            {
                Console.WriteLine("MENORr: " + num3);
            }

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa

        }
    }
}
