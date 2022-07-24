using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula21 URI 1002, Exercicico , Calcular a area da circunferência, tipo double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis, tipo double

            double n, raio, area;

            n = 3.14159;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando a variavel area 

            area = Math.Pow(raio, 2.0) * n;

            //imprimir saida de dados no console, método WhriteLine, concatenação
            
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa

        }
    }
}
