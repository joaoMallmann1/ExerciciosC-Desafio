using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Checagem de validade de triângulo");
            Console.Write("Digite o valor do primeiro lado: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            if(ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoB + ladoA)
            {
                Console.WriteLine("O triângulo é válido");
            }
            else
            {
                Console.WriteLine("O triângulo não é válido");
            }
        }
    }
}
