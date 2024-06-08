using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de média e apresentação de aprovação ou reprovação de um aluno");
            Console.Write("Digite o valor da primeira nota: ");
            double notaA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da segunda nota: ");
            double notaB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da terceira nota: ");
            double notaC = Convert.ToDouble(Console.ReadLine());

            double media = (notaA + notaB + notaC)/3;

            string resultado = media >= 7 ? "Aluno aprovado" :
                media >= 5 ? "Aluno em recuperação" :
                 "Aluno reprovado";  
            Console.WriteLine(resultado);
        }
    }
}
