using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio14
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor, se for positivo sua raiz quadrada será calculada, se negativo, o quadrado será informado: ");
            double val = Convert.ToDouble(Console.ReadLine());
            double raizQ = Math.Sqrt(val);
            if(val > 0)
            {
                Console.WriteLine($"O valor {val} é positivo e sua raiz é de {raizQ}");
            } else if(val < 0)
            {
                Console.WriteLine($"O valor {val} é negativo e seu quadrado é de {val * val}")
            } else
            {
                Console.WriteLine("O valor é nulo")
            }
        }
    }
}
