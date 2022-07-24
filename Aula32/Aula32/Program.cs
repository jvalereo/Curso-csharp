using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Curso Udemy - Aula32, Calculo Soma aluno, 
             estrutura condicional simples, tipo double*/
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double nota1, nota2, soma;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a 1 nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2 nota: ");
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a varia soma; 

            soma = nota1 + nota2;

            //Declarando estutura condicional simples

            if (soma < 60.0)
            {
                Console.WriteLine("Reprovado");
            }

            //imprimir saida de dados no console, smétodo WhriteLine, concatenação

            Console.WriteLine("Nota Final: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}

