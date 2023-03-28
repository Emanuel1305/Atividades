using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumilharHenrique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor de 1 a 5: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("A Mãe do Henrique é esbelta");
                    break;
                case "2":
                    Console.WriteLine("A Mãe do Henrique é totosa");
                    break;
                case "3":
                    Console.WriteLine("A Mãe do Henrique é gata");
                    break;
                case "4":
                    Console.WriteLine("A Mãe do Henrique é deliciosa");
                    break;
                case "5":
                    Console.WriteLine("A Mãe do Henrique é maravilhosa");
                    break;
                default:
                    Console.WriteLine("Comi sua Mãe meu grande amigo Henrique");
                    break;
            }
            Console.ReadLine();
        }
    }
}
