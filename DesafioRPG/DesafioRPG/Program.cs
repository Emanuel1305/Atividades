using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializando a integridade do herói e do monstro
            int heroIntegrity = 10;
            int monsterIntegrity = 10;

            // Loop principal do jogo
            while (heroIntegrity > 0 && monsterIntegrity > 0)
            {
                // Ataque do herói
                Console.WriteLine("\nHerói Ataca!");
                int heroAttack = new Random().Next(1, 11); // Gera um valor aleatório entre 1 e 10
                monsterIntegrity -= heroAttack;
                Console.WriteLine($"O monstro foi danificado e perdeu {heroAttack} saúde e agora tem {monsterIntegrity} saúde.");

                // Verifica se o monstro ainda está vivo antes de atacar
                if (monsterIntegrity > 0)
                {
                    // Ataque do monstro
                    Console.WriteLine("\nMontro Ataca!");
                    int monsterAttack = new Random().Next(1, 11); // Gera um valor aleatório entre 1 e 10
                    heroIntegrity -= monsterAttack;
                    Console.WriteLine($"O herói foi danificado e perdeu {monsterAttack} saúde e agora tem {heroIntegrity} saúde.");
                }
            }

            // Verifica quem venceu o jogo
            if (heroIntegrity <= 0)
            {
                Console.WriteLine("\nO monstro venceu!");
            }
            else
            {
                Console.WriteLine("\nO herói venceu!");
            }

            // Aguarda o usuário pressionar alguma tecla antes de fechar a aplicação
            Console.ReadKey();
        }
    }
}
