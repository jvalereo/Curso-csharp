using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula16, Calculo areado do quadrado, tipo double
            // Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            double largura;
            double comprimento;
            double area;
            double preco; 
            double PrecoTotalQuadrado;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o valor da largua: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do preço do quadrado: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variavel area;

            area = largura * comprimento;

            //Declarando a variavel PrecoTotalQuadrado;

            PrecoTotalQuadrado = area * preco;

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("O Resultado é: ");
            Console.WriteLine();
            Console.WriteLine("O valor da area é : " 
                + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Preço total metro Quadrado é: " 
                + PrecoTotalQuadrado.ToString("F2", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama
            
        }
    }
}
