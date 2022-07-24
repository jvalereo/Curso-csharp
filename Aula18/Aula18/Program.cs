using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Curso Udemy - Aula18, Calcular, area, perimetro, 
             diagonal do quadrado, tipo double*/
            //Jonas Valereo - Técnico em Infomática

            //Declarando as variaveis tipo double

            double b, a, area, perimento, diagonal;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite a base do quadrado: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Altura do quadrado: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarando a variavel area

            area = b * a; 

            //Declarando a varivel perimento

            perimento = 2 *  b +  2 * a ;

            //Declarando a variavel diagonal

            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("O valor da area é: " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do perimentro é: " + perimento.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O valro da diagonal é: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();
            
            //Fim do programa

        }
    }
}
