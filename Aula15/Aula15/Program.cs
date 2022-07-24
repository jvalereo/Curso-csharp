using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso Udemy - Aula15, Calcular area do quadrado, tipo double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double largura, comprimento, area, preco;

            largura = 10.0;
            comprimento = 30.0;
            preco = 200.0;

            //Declarando a variavel area

            area = largura * comprimento;
            preco =  area * 200.00 ;

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("Resultado total da area e preço: ");
            Console.WriteLine();
            Console.WriteLine("O valor da area: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O preço total da area: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama

        }
    }
}
