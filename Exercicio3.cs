using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Leitura de dois números inteiros e checagem de maior ou menor");
            Console.Write("Digite um primeiro valor: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            string resultado = valorA > valorB ? $"O primeiro valor é maior que o segundo" :
                valorA < valorB ? $"O segundo valor é maior que o primeiro" :
                $"Ambos os valores são iguais";
            Console.Write(resultado);
        }
    }
}
