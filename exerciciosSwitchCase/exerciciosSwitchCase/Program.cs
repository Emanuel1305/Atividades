using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Lê dois números e execulta operações com esses valores----\n");
            double v1, v2;
            Console.Write("Informe o primeiro número: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme qual operação deseja realizar:" +
                "\n\t[1] Adição" +
                "\n\t[2] Subtração" +
                "\n\t[3] Mutiplicação" +
                "\n\t[4] Divisão");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Limpar();
                    Console.Write($"{v1} + {v2} = {v1 + v2}");
                    break;
                case 2:
                    Limpar();
                    Console.Write($"{v1} - {v2} = {v1 - v2}");
                    break;
                case 3:
                    Limpar();
                    Console.Write($"{v1} x {v2} = {v1 * v2}");
                    break;
                case 4:
                    Limpar();
                    Console.Write($"{v1} / {v2} = {v1 / v2}");
                    break;
                default:
                    Limpar();
                    Console.Write("O valor informado não é valido.");
                    break;
            }
            Console.ReadLine();
        }

        private static void Limpar()
        {
            Console.Clear();
            Console.WriteLine("\t\t----Lê dois números e execulta operações com esses valores----\n");
        }

    }
}
