using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eercicio 05

            Console.Write("\t-----CALCULAR O CONSUMO DE COMBUSTIVEL-----\t\n\n");
            Console.Write("Informe a quantidade de litros: ");
            double litros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade de quilômetros poercorridos: ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("\t-----TOTAL DE KM PERORRIDOS POR LITROS DE COMBUSTIVEL-----\t\n\n");
            Console.Write($"O veiculo está consumindo uma média de {km / litros} kilômetros por litro de combustivel");
            Console.ReadKey();

        }
    }
}
