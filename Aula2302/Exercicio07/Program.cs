using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 07

            Console.Write("\t-----INFORMAÇÕES DE UMA PRESTAÇÃO-----\t\n\n");
            Console.Write("Informe o total de prestações: ");
            int totalPrestacoes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quantidade de prestações pagas: ");
            int qantidadePrestacoesPagas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor da prestação: ");
            double valorPrestacao = Convert.ToDouble(Console.ReadLine());
            double totalPago = qantidadePrestacoesPagas * (valorPrestacao / totalPrestacoes);

            Console.Clear();
            Console.Write("\t-----TOTAL PAGO / SALDO DO DEVEDOR-----\t\n\n");
            Console.Write($"Valor total pago =\t{totalPago} reais\nSaldo do Devedor =\t{valorPrestacao - totalPago} reais");
            Console.ReadKey();
        }
    }
}
