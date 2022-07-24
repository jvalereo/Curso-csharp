using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuso Udemy - Aula20, Calcular conversão de minutos, tip int
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo int 

            int N, horas, resto, minutos, segundos;


            //Declarando o codigo entrada de dado no console, método ReadLine

            N = int.Parse(Console.ReadLine());

            //Declarando as variaveis horas , resto

            horas = N / 3600;
            resto = N % 3600;

            //Declarando as variaveis minuntos, segundo

            minutos = resto / 60;
            segundos = resto % 60;

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama
           
        }
    }
}
