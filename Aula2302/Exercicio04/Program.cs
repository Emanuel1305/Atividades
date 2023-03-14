using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 04

            Console.Write("\t-----CALCULAR O VOLUME DE UMA CAIXA RETANGULAR-----\t\n\n");
            Console.Write("Informe a largura do retangulo: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura do retangulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a profundidade do retangulo: ");
            double profundidade = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("\t-----VOLUME DA CAIXA-----\t\n\n");
            Console.Write($"O volume da Caixa é de {(largura * altura * profundidade) / 1000}");
            Console.ReadKey();
        }
    }
}
