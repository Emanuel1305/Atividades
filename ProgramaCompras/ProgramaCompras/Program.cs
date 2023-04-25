using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Ajuda nas compras---\n");
            Console.Write("Informe o valor que tem disponivel para compras: ");
            double saldo = Double.Parse(Console.ReadLine());
            double compra = 0, somaCompras = 0;
            int contCompras = 0;
            bool podeComprar = true;
            do
            {
                Console.Write("\nInforme o valor da compra: ");
                compra = Double.Parse(Console.ReadLine());
                if (compra > 0)
                {
                    if (compra <= saldo)
                    {
                        saldo = saldo - compra;
                        somaCompras = somaCompras + compra;
                        contCompras++;
                        Console.WriteLine("\nPode comprar\nSaldo disponivel: {0:c2}", saldo);
                    }
                    else
                    {
                        podeComprar = false;
                    }

                }
                else
                {
                    Console.WriteLine("\nCorrija o valor da compra!");
                }

            } while (podeComprar == true);
            Console.Clear();
            Console.WriteLine("\t\t---Resultado das Compras---");
            Console.WriteLine("\nJá não pode comprar!\nSaldo Insuficiente!");
            Console.WriteLine($"\nNúmero de compras: {contCompras}" +
                $"\nTotal Gasto: {somaCompras:c2}" +
                $"\nSaldo Restante: {saldo:c2}");
            Console.ReadKey();
        }
    }
}
