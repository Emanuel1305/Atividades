using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSalarioBruto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calcula o valor de imposto de renda---\n" +
                "===========================================================");

            const double taxa1 = 0.075;
            const double taxa2 = 0.15;

            string msg = "";
            string nome;
            double salario, imposto, totalImposto = 0.0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe os dados da pessoa {0}:", i);
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário bruto: R$ ");
                salario = double.Parse(Console.ReadLine());


                if (salario < 1000.0)
                {
                    imposto = 0;
                }
                else if (salario < 1500.0)
                {
                    imposto = salario * taxa1;
                }
                else
                {
                    imposto = salario * taxa2;
                }

                totalImposto += imposto;

                msg += $"Nome:\t\t\t{nome}\n" +
                    $"Imposto de Renda:\tR$ {imposto:F2}\n\n";

                Console.Clear();
                Console.WriteLine("\t\t---Calcula o valor de imposto de renda---\n" +
                "===========================================================");
            }

            Console.WriteLine($"{msg}\nTotal de Imposto de Renda a ser pago: R$ {totalImposto:F2}");
            Console.WriteLine("===========================================================");
            Console.ReadKey();
        }
    }
}
