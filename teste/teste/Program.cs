using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testando codigo 
            //Jonas valereo - Técnico em informátia
            int x;
            string dia; 
            Console.WriteLine("Digite o número da da semanha!");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    dia = "segunda";
                    break;
                case 2:
                    dia = "terça";
                    break;
                case 3:
                    dia = "quarta - feria";
                    break;
                case 4:
                    dia = "quinta - feira";
                    break;
                case 5:
                    dia = "sexta - feira";
                    break;
                case 6 :
                    dia = "sabado";
                    break;
                case 7:
                    dia = "domingo";
                    break;
                default:
                    dia = "não exite";
                    break;


            }

            Console.WriteLine("Dia " + dia);
            Console.ReadKey();
        }
    }
}