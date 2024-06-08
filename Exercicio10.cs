using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            string escolha = Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            if(escolha == "1")
            {
                Console.WriteLine($"A operação correspondente de {valorA} + {valorB} = {valorA + valorB}");
            } else if(escolha == "2")
            {
                Console.WriteLine($"A operação correspondente de {valorA} - {valorB} = {valorA - valorB}");
            }
            else if (escolha == "3")
            {
                Console.WriteLine($"A operação correspondente de {valorA} x {valorB} = {valorA * valorB}");
            }
            else if (escolha == "4")
            {
                Console.WriteLine($"A operação correspondente de {valorA} / {valorB} = {valorA / valorB}");
            }
            else
            {
                Console.WriteLine("Operação invalida");
            }
        }
    }
}
