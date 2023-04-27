using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRPG
{
    class Game
    {
        private int vidaHeroi = 10;
        private int vidaMonstro = 10;
        private Random random = new Random();

        public void IniciarJogo()
        {
            Console.WriteLine("\t\t*** O jogo começou!! ***\n\n" +
                "======================================================================================================");

            while (vidaHeroi > 0 && vidaMonstro > 0)
            {
                AtaqueHeroi();
                if (vidaMonstro <= 0) break;
                AtaqueMonstro();
            }

            if (vidaHeroi > 0)
            {
                Console.WriteLine("======================================================================================================");
                Console.WriteLine("\n\t\t*** O herói venceu! ***");
            }
            else
            {
                Console.WriteLine("======================================================================================================");
                Console.WriteLine("\n\t\t*** O monstro venceu! ***");
            }

            Console.WriteLine("\t\t--- O jogo acabou! ---");
        }

        private void AtaqueHeroi()
        {
            int attackValue = random.Next(1, 11);
            vidaMonstro -= attackValue;
            Console.WriteLine("\tO monstro foi danificado e perdeu {0} pontos de saúde e agora tem {1} pontos de saúde.", attackValue, vidaMonstro);
        }

        private void AtaqueMonstro()
        {
            int attackValue = random.Next(1, 11);
            vidaHeroi -= attackValue;
            Console.WriteLine("\tO herói foi danificado e perdeu {0} pontos de saúde e agora tem {1} pontos de saúde.", attackValue, vidaHeroi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Simulador de RPG---\n");
            Game game = new Game();
            game.IniciarJogo();
            Console.ReadLine();

        }
    }
}
