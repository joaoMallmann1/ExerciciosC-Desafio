using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Checagem de ano bissexto ---->");
            Console.Write("Digite o ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine("O ano digitado é bissexto");
            }else { Console.WriteLine("Ano comum"); }
        }
    }
}
