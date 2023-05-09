using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resp = 1;
            int soma = 0;
            Random dado = new Random();

            
            while (resp == 1)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"{i}° lançameto");

                    int numero = dado.Next(1, 6);
                    Console.WriteLine("Número: " + numero);
                    soma += numero;
                    Console.WriteLine("Soma: " + soma + "\n");

                    if (soma > 9)
                    {
                        Console.WriteLine($"Você ganhou com {i} lançamentos ");
                        break;
                    }

                }
                if (soma < 9)
                {
                    Console.WriteLine("Você perdeu! Seu pato!!!");
                }
                Console.WriteLine("Deseja jogar novamente? \n[1] SIM\n[2] NÃO");
                resp = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
