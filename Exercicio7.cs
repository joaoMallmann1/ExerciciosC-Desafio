using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Checagem de idade e apresentação de fase da vida --->");
            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            string resultado = idade <= 12 ? "A pessoa é uma criança" :
                idade <= 17 ? "A pessoa é uma adolescente" :
                idade <= 59 ? "A pessoa é adulta" :
                "A pessoa é idosa";
            Console.WriteLine(resultado);
        }
    }
}
