using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Leitura de número e checagem se é maior que 100 e o dobro se não for --->");
            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            string result = valor < 100 ? $"{valor} não é maior que 100 e o dobro de seu valor é {valor * 2}" :
                valor > 100 ? "O valor é maior que 100" :
                "O valor é igual a 100";
            Console.WriteLine(result);
        }
    }
}
