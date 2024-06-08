using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da compra:");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a categoria do cliente:");
            Console.WriteLine("1 - Comum");
            Console.WriteLine("2 - Associado");
            Console.WriteLine("3 - VIP");
            int categoria = Convert.ToInt32(Console.ReadLine());

            double valorFinal = 0;

            switch (categoria)
            {
                case 1: 
                    valorFinal = valorCompra;
                    break;
                case 2: 
                    valorFinal = valorCompra * 0.9;
                    break;
                case 3: 
                    valorFinal = valorCompra * 0.8;
                    break;
                default:
                    Console.WriteLine("Categoria inválida.");
                    return; 
            }

            Console.WriteLine($"O valor final da compra é: {valorFinal:C2}");
        }
    }
}
