using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---exibe qual o maior nome e sua quantidade de letras---\n");

            Console.Write("Informe o primeiro nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o segundo nome: ");
            string nome2 = Console.ReadLine();

            int cont1 = nome.Length;
            int cont2 = nome2.Length;

            if (cont1 > cont2)
            {
                Console.Write($"\n{nome} é o maior nome, possúi {cont1} letras!");
            }
            else if (cont1 < cont2)
            {
                Console.Write($"\n{nome2} é o maior nome, possúi {cont2} letras!");
            }
            else
            {
                Console.Write($"\nOs nomes são do mesmo tamanho, ambos possuem {cont1} letras!");
            }

            Console.ReadLine();
        }
    }
}
