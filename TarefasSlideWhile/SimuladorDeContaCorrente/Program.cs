using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            int opc = 0;
            Console.WriteLine("\t\t---Simulador de conta corrente---\n");
            Console.WriteLine("O que você quer fazer?" +
                "\n1. Depositar" +
                "\n2. Sacar" +
                "\n3. Exibir Saldo" +
                "\n4. Sair");
            while (opc != 4)
            {
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Write($"Sua opção: [{opc}] Depositar" +
                        $"\nQual valor deseja depositar? ");
                    saldo = saldo + double.Parse(Console.ReadLine());

                }
                else if (opc == 2)
                {
                    Console.Write($"Sua opção: [{opc}] Sacar" +
                        $"\nQual valor deseja sacar? ");
                    saldo = saldo - double.Parse(Console.ReadLine());
                }
                else if (opc == 3)
                {
                    Console.Write($"Sua opção: [{opc}] Exibir Saldo" +
                        $"\nSaldo: {saldo}");
                }
                else
                {
                    Console.WriteLine($"Sua opção: [{opc}] Sair");
                    Console.WriteLine("Opção inválida");
                }
                opc = 0;
                Console.Clear();
                Console.WriteLine("\t\t---Simulador de conta corrente---\n");
                Console.WriteLine("O que você quer fazer?" +
                    "\n1. Depositar" +
                    "\n2. Sacar" +
                    "\n3. Exibir Saldo" +
                    "\n4. Sair");
            }
            
            Console.ReadLine();
        }
    }
}
