using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio2
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Leitura de número e checagem se é positivo, nulo ou negativo -->");
            Console.Write("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            string resultado = valor > 0 ? $"{valor} é positivo" :
                valor < 0 ? $"{valor} é negativo" :
                $"{valor} é nulo";
            Console.WriteLine(resultado);
        }
    }
}
