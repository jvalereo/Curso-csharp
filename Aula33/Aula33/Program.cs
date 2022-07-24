using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Aula33
{
    class Program
    {
        static void Main(string[] args)
        {

            //Curso Udemy - Aula33, Calculo media aluno, estrutura condicional, tipo double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            double nota1, nota2, nota3, media;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Nota Final do Aluno");
            Console.WriteLine();
            Console.WriteLine("Digite a nota de portugues:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota de matemática:");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota de ciência:");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variavel medio do aluno

            media = (nota1 + nota2 + nota3) / 3;

            //Declarando estrutura condicional composta, if e else

            if (media > 7)
            {
                Console.WriteLine("Parabéns, Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Infelizmente, Aluno Reprovado");
            }

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("Média do Aluno =  " + media.ToString("F2", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
