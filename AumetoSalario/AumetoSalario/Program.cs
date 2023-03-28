using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumetoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Calcula Aumento Salarial----");
            Console.Write("\n\t[1] Gerente\n\t[2] Engenheiro\n\t[3] Técnico");
            Console.Write("\n\nInforme o Cargo: ");
            int cargo = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Salário: ");
            double salario = double.Parse(Console.ReadLine());

            double novosalario = 0;

            switch (cargo)
            {
                case 1:
                    novosalario = salario + (salario * 0.1);
                    Console.WriteLine();
                    break;
                case 2:
                    novosalario = salario + (salario * 0.2);
                    break;
                case 3:
                    novosalario = salario + (salario * 0.3);
                    break;
                default:
                    novosalario = salario + (salario * 0.4);
                    break;
            }

            Console.WriteLine($"\nSalário antigo: {salario.ToString("c2")}" +
                $"\nNovo Salário: {novosalario.ToString("c2")}" +
                $"\nValor do Reajuste: {(novosalario - salario).ToString("c2")}");
            Console.ReadKey();
        }
    }
}
