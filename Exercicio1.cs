using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio1
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Checagem de ímpar ou par --->");
            Console.Write("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if(valor % 2 == 0)
            {
                Console.WriteLine("O valor é par");
            }
            else
            {
                Console.WriteLine("O valor é ímpar");
            }
        }
    }
}
