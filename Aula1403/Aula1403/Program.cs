using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica se o número é par ou impar---\n");

            Console.Write("Informe o numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("\nEste número é par!");
            }
            else
            {
                Console.WriteLine("\nEste número é impar!");
            }

            Console.ReadKey();
        }
    }
}
