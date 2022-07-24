using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Curso Udemy - Aula12, inserir dados de entrada, vetor,
            tipo int, string, double, concatenãção*/
            //Jonas Valereo - Técnico em Informática 

            //Declarando as vareaveis, vetor, split, tip string, int, double

            //Declarando o vetor vet, tipo string, converte em string 

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            int idade = int.Parse((vet[1]));
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double peso = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine();

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("Resposta:");
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Sua idade: " + idade + " " + "anos");
            Console.WriteLine("Sua altura: " + altura.ToString("F2" ,CultureInfo.InvariantCulture) + " " + "metros" );
            Console.WriteLine("Seu peso: " + peso.ToString("F2", CultureInfo.InvariantCulture) +  " " + "kg");

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
