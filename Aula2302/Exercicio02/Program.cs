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
            //Exercicio 2
            Console.WriteLine("\t\t---MUTIPLICA DOIS VALORES---\n");

            Console.Write("Inforome o primeiro Número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inforome o segundo Número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\n{n1}*{n2} = {n1 * n2}");

            Console.ReadKey();

        }
    }
}
