using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            Console.WriteLine(data);

            DateTime entrada = DateTime.Now;
            Console.WriteLine(entrada);

            string hora = DateTime.Now.ToShortTimeString();
            Console.WriteLine(hora);

            string dia = DateTime.Now.ToShortDateString();
            Console.WriteLine(dia);

            DateTime criacaoifro = new DateTime(2022, 12, 29, 14, 35, 23);
            string criacaoformatada = criacaoifro.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(criacaoformatada);

            DateTime dt = new DateTime(2008, 12, 29);
            Console.WriteLine(dt);
            //Acrecentando 140 dias
            dt = dt.AddDays(140);

            //Acrecentando -2 anos
            dt = dt.AddYears(-2);

            //Acrecentando 72 horas
            dt = dt.AddHours(72);
            Console.WriteLine(dt);

            Console.ReadKey();
        }
    }
}
