using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calcular a Média Geral de uma Turma de alunos---\n");
            Console.Write("Qual o número de alunos que a turma possui: ");
            int num = int.Parse(Console.ReadLine());

            int cont = 1;
            while (cont<=num)
            {
                Console.Write($"Informe a nota do {cont}° Aluno: ");
                Console.Write("\n1° Bimestre: ");
                double m1 = double.Parse(Console.ReadLine());
                Console.Write("\n2° Bimestre: ");
                double m2 = double.Parse(Console.ReadLine());
                Console.Write("\n3° Bimestre: ");
                double m3 = double.Parse(Console.ReadLine());
                Console.Write("\n4° Bimestre: ");
                double m4 = double.Parse(Console.ReadLine());
            }

        }
    }
}
