using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauculaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Calcula nota do aluno----\n");
            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("\nNota do 1° Bimestre: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 2° Bimestre: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 3° Bimestre: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 4° Bimestre: ");
            double n4 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4)/4;
            char conceito = ' ';

            if (media >= 90)
            {
                conceito = 'A';
            } else if (media >= 80)
            {
                conceito = 'B';
            } else if (media >= 60)
            {
                conceito = 'C';
            }
            else if (media >= 40)
            {
                conceito = 'D';
            }
            else if (media >= 20)
            {
                conceito = 'E';
            }
            else
            {
                Console.Write("o aluno está reprovado");
            }

            switch (conceito)
            {
                case 'A':
                    Console.WriteLine($"\nNome:\t\t{nome}\n" +
                        $"Conceito:\t{conceito}\n" +
                        $"Situação:\tAprovado");
                    break;
                case 'B':
                    Console.WriteLine($"\nNome:\t\t{nome}\n" +
                        $"Conceito:\t{conceito}\n" +
                        $"Situação:\tAprovado");
                    break;
                case 'C':
                    Console.WriteLine($"\nNome:\t\t{nome}\n" +
                        $"Conceito:\t{conceito}\n" +
                        $"Situação:\tAprovado");
                    break;
                case 'D':
                    Console.WriteLine($"\nNome:\t\t{nome}\n" +
                        $"Conceito:\t{conceito}\n" +
                        $"Situação:\tRecuperação");
                    break;
                case 'E':
                    Console.WriteLine($"\nNome:\t\t{nome}\n" +
                        $"Conceito:\t{conceito}\n" +
                        $"Situação:\tExame");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
