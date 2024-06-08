using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão de nota de aluno em conceito ---->");
            Console.Write("Digite a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            string resultado = nota <= 3 ? "Nota F" :
                nota <= 5 ? "Nota D" :
                nota <= 7 ? "Nota C" :
                nota < 9 ? "Nota B" :
                "Nota A";
            Console.WriteLine(resultado);
        }
    }
}
