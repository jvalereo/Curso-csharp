using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Curso Udemy - Aula35, execicio URI 2009, calcule salario com bonus
             tipo primitivo , string double*/
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo doulbe

            string nome;
            double salarioFixo, totalVendas, totalReceber;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário fixo: ");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o total de vendas: ");
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //declarando a variavel totalReceber do salario bonus

            totalReceber = totalVendas  * 15.0 / 100 + salarioFixo;

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Nome =  " + nome);
            Console.WriteLine("Valor total a recebe = " + totalReceber.ToString("F2", CultureInfo.InvariantCulture));
        
            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa

        }
    }
}
