using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Leitura de código de alimento e informação sobre perecibilidade ---->");
            Console.Write("Digite o código do produto: ");
            int cod = Convert.ToInt32(Console.ReadLine());

            string resultado = cod < 1 || cod > 40 ? "Código invalido" :
                cod <= 10 ? "Alimento não perecível" :
                cod <= 20 ? "Alimentos perecíveis" :
                cod <= 30 ? "Vestuário" :
                "Eletrônicos";
            Console.WriteLine(resultado);
        }
    }
}
