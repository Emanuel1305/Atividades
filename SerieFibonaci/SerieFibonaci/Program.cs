using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Fibonacci---\n");
            Console.WriteLine("Clique qualquer tecla para continuar");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\t\t---Fibonacci---\n" +
                "==============================================\n");

            int a = 1, b = 1, c;

            Console.WriteLine($"1° termo -\t{a}");
            Console.WriteLine($"1° termo -\t{b}");

            for (int i = 3; i <= 10; i++)
            {
                c = a + b;
                Console.WriteLine($"{i}° termo -\t{a} + {b} = {c}");
                a = b;
                b = c;
            }

            Console.WriteLine("\n==============================================");
            Console.ReadKey();
        }
    }
}
