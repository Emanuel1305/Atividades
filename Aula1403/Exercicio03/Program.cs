using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Informa se um aluno foi aprovado---\n");

            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("\nInforme a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.Write("Informe a quarta nota: ");
            double n4 = double.Parse(Console.ReadLine());
            string ap = " ";

            double media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 60)
            {
                ap += "Aprovado";
            }
            else
            {
                ap += "Reprovado";
            }

            Console.Clear();
            Console.WriteLine("\t\t---Informa se um aluno foi aprovado---\n");
            Console.Write($"Aluno:\t{nome}\nMédia:\t{media}\nO aluno foi {ap.ToUpper()}!");

            Console.ReadKey();
        }
    }
}
