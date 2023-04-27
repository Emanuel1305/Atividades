using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\t\t---Calcula reajuste salarial de 10 funcionários---\n");
            double salario, reajuste, novoSalario;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o salário do {i+1}° funcionário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario > 0)
                {
                    if (salario < 1000)
                    {
                        reajuste = salario * 0.55;
                        novoSalario = salario + reajuste;
                        Console.WriteLine("\n\t\t---Reajuste---\n");
                        Console.WriteLine("salário atual: {0:c2}", salario);
                        Console.WriteLine("\nReajuste: {0:c2}", reajuste);
                        Console.WriteLine("\nNovo salário: {0:c2}", novoSalario);
                    }
                    else if (salario <= 2500)
                    {
                        reajuste = salario * 0.30;
                        novoSalario = salario + reajuste;
                        Console.WriteLine("\n\t\t---Reajuste---\n");
                        Console.WriteLine("salário atual: {0:c2}", salario);
                        Console.WriteLine("\nReajuste: {0:c2}", reajuste);
                        Console.WriteLine("\nNovo salário: {0:c2}", novoSalario);
                    }
                    else
                    {
                        reajuste = salario * 0.20;
                        novoSalario = salario + reajuste;
                        Console.WriteLine("\n\t\t---Reajuste---\n");
                        Console.WriteLine("salário atual: {0:c2}", salario);
                        Console.WriteLine("\nReajuste: {0:c2}", reajuste);
                        Console.WriteLine("\nNovo salário: {0:c2}", novoSalario);
                    }
                    Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\t\t---Calcula reajuste salarial de 10 funcionários---\n");
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
                
            }
            Console.WriteLine("\nAperte qualquer tecla para sair: ");
            Console.ReadKey();
        }
    }
}
