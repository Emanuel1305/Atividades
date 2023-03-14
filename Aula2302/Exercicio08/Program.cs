using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 08

            Console.Write("\t-----LEITURA DE DOIS NUMEROS REAIS-----\t\n\n");
            Console.Write("1° Número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2° Número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t-----OPERAÇÕES-----\t\n\n");
            Console.Write($"{n1} + {n2} = {n1 + n2}\n{n1} - {n2} = {n1 - n2}\n{n1} / {n2} = {n1 / n2}\n{n1} * {n2} = {n1 * n2}\n");
            Console.ReadKey();
        }
    }
}
