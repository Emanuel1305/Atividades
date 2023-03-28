using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçaoHHH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t----Verificação Peniana----\n");
            Console.Write("Informe o tamanho do seu Pênis em centímetros: ");
            int tamanho = int.Parse(Console.ReadLine());

            if (tamanho >= 5 && tamanho <= 10)
            {
                Console.WriteLine("\nQue cut cut");
            }
            else if (tamanho >= 11 && tamanho <= 15)
            {
                Console.WriteLine("\nPode melhorar, 'Passa um Libid Gel que é sucesso!'");
            }
            else if (tamanho >= 16 && tamanho <= 20)
            {
                Console.WriteLine("\nQue isso em!! Tá potente, o tamanho ideal para arrasar corações!");
            }
            else if (tamanho >= 21 && tamanho <= 1000)
            {
                Console.WriteLine("\nQuem é Kid Bengala perto de vc slk, o famoso estora últero");
            }
            else if (tamanho >= 0 && tamanho <= 4)
            {
                Console.WriteLine("\nkkkkkkkkkkkk VC É UMA VERGONHA PRO SEXO MASCULINO");
            }
            Console.ReadKey();
        }
    }
}
