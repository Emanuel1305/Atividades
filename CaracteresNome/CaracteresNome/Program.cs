using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Imprime o nome de acordo com a sua quantidade de caracteres---\n" +
                "=======================================================================================");

            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\t\t---Imprime o nome de acordo com a sua quantidade de caracteres---\n" +
                "=======================================================================================\n");

            int carac = nome.Length;

            Console.WriteLine($"{nome} possúi {carac} caracteres!\n");

            for (int i = 1; i <= carac; i++)
            {
                Console.WriteLine($"{i} - {nome}");
            }

            Console.WriteLine("\n=======================================================================================");

            Console.ReadKey();
        }
    }
}
