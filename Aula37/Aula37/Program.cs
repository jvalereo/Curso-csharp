using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula37, Calcule o volume da esfera, tipo double
            //Jonas Valereo -  Técnico em Informática

            //declarando as variavies tipo double

            double volume, volu, pi, R;

            //declarando as variavies volu, pi 

            volu = 4 / 3.0;
            pi = 3.14159;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o valor do raio: ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //declarando a variavel volume 

            volume = volu* pi * Math.Pow(R, 3.0);

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa
        }
    }
}
