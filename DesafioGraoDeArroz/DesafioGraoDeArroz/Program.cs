using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGraoDeArroz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = 1;
            decimal b = 0;
            decimal c = 0;
            for (int i = 1; i <= 64; i++)
            {
                b = a * 2;
                c = b * 2;
                Console.WriteLine($"O {i} quadrado receberá: "+a.ToString("n2"));
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
