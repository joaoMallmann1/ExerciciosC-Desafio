using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCsharp
{
    internal class Exercicio15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso (em kg):");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura (em metros):");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);

            Console.WriteLine($"Seu IMC é: {imc:F2}");

            string categoria = InterpretarIMC(imc);

            Console.WriteLine($"Categoria: {categoria}");
        }
        static double CalcularIMC(double peso, double altura)
        {
            // Fórmula do IMC: peso / (altura * altura)
            return peso / (altura * altura);
        }

        static string InterpretarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                return "Obesidade grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                return "Obesidade grau II";
            }
            else // IMC >= 40
            {
                return "Obesidade grau III";
            }
        }
    }
}
