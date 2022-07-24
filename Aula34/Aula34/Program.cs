﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula34, Calculo media do aluno,
            //estrutura condicional, tipo double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            double nota1, nota2, nota3, media;

            //Declarando o codigo entrada de dado no console, método ReadLine
            Console.WriteLine("Nota Final do Aluno");
            Console.WriteLine();
            Console.WriteLine("Digite a nota de portugues");
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota de matemática");
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota de ciência");
            nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variavel media

            media = (nota1 + nota2 + nota3) / 3;

            //Declarando Encadeamento estrutrual condicional composta if e else

            if (media > 7)
            {
                Console.WriteLine("Parabéns, Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aténção, Aluno Reprovado");
            }
           
            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Média do aluno: " + media.ToString("F1", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programas

        }
    }
}
