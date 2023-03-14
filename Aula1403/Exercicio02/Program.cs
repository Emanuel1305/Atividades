using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---lê três números inteiros e imprima o maior---\n");

            Console.Write("Informe o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine($"\n{num1} é o maior número");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine($"\n{num2} é o maior número");
            }
            else if (num3 > num2 && num2 > num1)
            {
                Console.WriteLine($"\n{num3} é o maior número");
            }
            else
            {
                Console.WriteLine("\nOs números são iguais");
            }

            Console.ReadKey();
        }
    }
}
