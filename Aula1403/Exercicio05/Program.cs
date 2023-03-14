using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--- lê o salario atual e exibe o salário reajustado ---\n");

            Console.Write("Informe o salário atual: ");
            double satu = Double.Parse(Console.ReadLine());
            if (satu >= 1500)
            {
                double reaj = 0.23;
                double sreaj = satu + (satu * reaj);
                Console.Write($"\nO salário com o reajuste de {reaj * 100}% toataliza em {sreaj} R$.");
            }
            else if (satu < 1500)
            {
                double reaj = 0.18;
                double sreaj = satu + (satu * reaj);
                Console.Write($"\nO salário com o reajuste de {reaj * 100}% toataliza em {sreaj} R$.");
            }
            Console.ReadKey();

        }
    }
}
