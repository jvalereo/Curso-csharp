using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula38 , Exercicio, Calcule a area, tipo double
            //Jonas Valereo - Técnico em Informática

            //declarando as variaveis tipo double

            double A, B, C, PI;
            double TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            //declarando a variavel pi

            PI = 3.14159;

            //declarando a variavel Array area 

            string[] AREA = Console.ReadLine().Split(' ');

            A = double.Parse(AREA[0], CultureInfo.InvariantCulture);
            B = double.Parse(AREA[1], CultureInfo.InvariantCulture);
            C = double.Parse(AREA[2], CultureInfo.InvariantCulture);

            //declarando a variavel triangulo

            TRIANGULO = (A * C) / 2.0;

            //declarando a variavel  circulo

            CIRCULO = PI * Math.Pow(C, 2.0);

            //declarando a variavel trapezio

            TRAPEZIO = (A + B) * C  / 2.0;

            //declarando a variavel quadrado

            QUADRADO = Math.Pow(B, 2.0);

            //declarando a variavel retangulo

            RETANGULO = A * B;

            //imprimir saida de dados no console, e método WhriteLine, concatenação
           
            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa

        }
    }
}
