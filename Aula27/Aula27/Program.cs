using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Curso Udemy - Aula27, Uri 1008,
            //Calcular o salário do funcionario, tipo, int, double 
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis, tipo int, double

            int numFuncionario, numHoraTrab;
            double horaReceber, SalarioFuncionario;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o Número de Funcionários: ");
            numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Número de Hora de Trabalho: ");
            numHoraTrab = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor Hora Receber: ");
            horaReceber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variaveil SalarioFuncionario

            SalarioFuncionario = horaReceber * numHoraTrab;

            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("Número de Funcionarios = " + numFuncionario);
            Console.WriteLine("Salário do Funcionário = U$ " + SalarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa 

        }
    }
}

