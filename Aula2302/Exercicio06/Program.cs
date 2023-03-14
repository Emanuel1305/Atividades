using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 06
            Console.Write("\t-----CONVERÇÃO DE DIAS EM SEMANAS, MESES E ANOS-----\t\n\n");

            Console.Write("Informe a quantidade de dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("\t-----CONVERÇÃO DE DIAS EM SEMANAS, MESES E ANOS-----\t\n\n");
            Console.Write($"{dias} dias = {dias / 7} semanas\n{dias} dias = {dias / 30} meses\n{dias} dias = {dias / 365} anos");
            Console.ReadKey();
        }
    }
}
