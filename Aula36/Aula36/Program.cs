using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula36, URI 1010, Calculo simples,
            //calculo de produto, tipo primitivo, int, double
            //Jonas Valereo - Técnico em Informática

            //declarando as variaveis, tipo int, double

            int codigoPeca1, numeroPeca1, codigoPeca2, numeroPeca2;
            double valorUnita1, valorUnita2, soma1, soma2, total;

            //declarando o codigo entrada de dado no console, método ReadLine, vetor

            string[] vetor = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(vetor[0],CultureInfo.InvariantCulture);
            numeroPeca1 = int.Parse(vetor[1],CultureInfo.InvariantCulture);
            valorUnita1 = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            vetor = Console.ReadLine().Split(' ');

            codigoPeca2 = int.Parse(vetor[0],CultureInfo.InvariantCulture);
            numeroPeca2 = int.Parse(vetor[1],CultureInfo.InvariantCulture);
            valorUnita2 = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            //declarando a variaveil soma1

            soma1 = codigoPeca1 + numeroPeca1  * valorUnita1;

            //declarando a variaveil soma2

            soma2 = codigoPeca2 + numeroPeca2 * valorUnita2;

            //declarando a variavel valor total

            total = soma1 + soma2;

            //imprimir saida de dados no console, e método WhriteLine, concatenação
           
            Console.WriteLine("VALOR A PAGAR = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa

        }
    }
}
