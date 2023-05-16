using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe data do seu nascimento: ");
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(dia, mes, ano);
            Console.WriteLine(dateTime);
            Console.ReadKey();
        }
    }
}
