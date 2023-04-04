using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Calcula desconto de acordo com o cliente----\n");
            Console.Write("Informe o valor do produto que deseja comprar: ");
            double vp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nCliente:" +
                "\n\t[1] Comum" +
                "\n\t[2] Funcionario" +
                "\n\t[3] Vip");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Limpar();
                    Console.Write($"O valor total do seu produto é de {vp.ToString("c2")}");
                    break;
                case 2:
                    Limpar();
                    double desc = vp * 0.10;
                    Console.Write($"O valor total do seu produto é de {(vp - desc).ToString("c2")}");
                    break;
                case 3:
                    Limpar();
                    double des = vp * 0.05;
                    Console.Write($"O valor total do seu produto é de {(vp - des).ToString("c2")}");
                    break;
            }
            Console.ReadKey();
        }
        private static void Limpar()
        {
            Console.Clear();
            Console.WriteLine("\t\t----Calcula desconto de acordo com o cliente----\n");
        }
    }
}
