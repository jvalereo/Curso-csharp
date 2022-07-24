using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula19
{
    class Program
    {


        static void Main(string[] args)
        {
            //Curso Udemy - Aula19 , programa para ler nome e idade, tipo string, int, double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo string , int, double

            string nome1;
            int idade1;
            string nome2;
            int idade2;
            double media;

            //Declarando a variavel v, vetor 

            string[] v = Console.ReadLine().Split(' ');

            nome1 = v[0];
            idade1   = int.Parse(v[1]);

            string[] f = Console.ReadLine().Split(' ');

            nome2 = f[0];
            idade2 = int.Parse(f[1]);

            //declarando variavel media, conversao casting

            media = (double)(idade1 + idade2) / 2;

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("A media de idade " + nome1 + " " + nome2 + " " 
                + media.ToString("F2", CultureInfo.InvariantCulture) + " " + "anos");

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
