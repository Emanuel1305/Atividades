using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome:\t\t");
            string nome = Console.ReadLine();
            Console.Write("Data Nasc.:\t");
            string dtNasc = Console.ReadLine();
            Console.Write("Idade\t\t");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("E-mail:\t");
            string eMail = Console.ReadLine();
            Console.Read();
        }
    }
}
