using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"O número {numero} está dentro do intervalo de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não está dentro do intervalo de 10 a 20.");
            }
        }
    }
}
