using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula28, URI 1010, Calculo simple de peça, tipo int , double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo int, double

            int codigPeca1, numPeca1;
            double valorUnPeca1;
            double valor1;
            int codigPeca2, numPeca2;
            double valorUnPeca2;
            double valor2;
            double valorTotal;
           
            //Declarando o vetor1, split

           string [] vetor1 = Console.ReadLine().Split(' ');

            codigPeca1 = int.Parse(vetor1[0]);
            numPeca1 = int.Parse(vetor1[1]);
            valorUnPeca1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

            //Declarando o vetor2, split

            string[] vetor2 = Console.ReadLine().Split(' ');

            codigPeca2 = int.Parse(vetor2[0]);
            numPeca2 = int.Parse(vetor2[1]);
            valorUnPeca2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            //Declarando variavel valor1, valor2, valortotal

            valor1 = (numPeca1 * valorUnPeca1) ;

            valor2 = (numPeca2 * valorUnPeca2);

            valorTotal =  valor1 +  valor2  ;

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("VALOR A PAGAR = " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
