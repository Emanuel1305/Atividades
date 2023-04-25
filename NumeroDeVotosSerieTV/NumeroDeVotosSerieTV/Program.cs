using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroDeVotosSerieTV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosBBT = 0;
            int votosGoT = 0;
            int votosSPN = 0;
            int votosBrancos = 0;
            int votosNulos = 0;
            int totalEleitores = 0;
            string resposta = "";

            do
            {
                resposta = "";
                Console.WriteLine("=== MENU DE VOTAÇÃO ===");
                Console.WriteLine("1 - The Big Bang Theory");
                Console.WriteLine("2 - Game of Thrones");
                Console.WriteLine("3 - Supernatural");
                Console.WriteLine("4 - Outra (votos brancos)");
                Console.WriteLine("5 - Não sabe (votos nulos)");
                Console.WriteLine("=======================");

                Console.Write("Digite o número da sua escolha: ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        votosBBT++;
                        break;
                    case 2:
                        votosGoT++;
                        break;
                    case 3:
                        votosSPN++;
                        break;
                    case 4:
                        votosBrancos++;
                        break;
                    case 5:
                        votosNulos++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                        
                }
                Console.Write("Você deseja continuar votando?\nDigite [SIM] ou [s] para prosseguir com a votação: ");
                resposta = Console.ReadLine().ToUpper();

                totalEleitores++;
                Console.WriteLine();
            } while (resposta == "SIM" || resposta == "s");

            Console.WriteLine("=== RESULTADO DA VOTAÇÃO ===");
            Console.WriteLine("Total de eleitores: " + totalEleitores);
            Console.WriteLine("The Big Bang Theory: " + votosBBT);
            Console.WriteLine("Game of Thrones: " + votosGoT);
            Console.WriteLine("Supernatural: " + votosSPN);
            Console.WriteLine("Votos brancos: " + votosBrancos);
            Console.WriteLine("Votos nulos: " + votosNulos);

            Console.ReadKey();
        }
    }
}
