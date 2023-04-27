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
        public string nomeHeroi = "";
        private Random random = new Random();

        public void IniciarJogo()
        {
            Console.WriteLine("\t\t---DESAFIO RPG---\n\t\t---Tela Iicial ---\n");
            Console.WriteLine("Para embarcar nessa incrivel jorada, Informe o nome que seu valoroso herói carregará!\n");
            Console.Write("Nome: ");
            nomeHeroi = Console.ReadLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\t\t---DESAFIO RPG---\n\t\t---Tela Iicial ---\n");
            Console.WriteLine($"O nome do seu Herói foi definido!\nDesejamos boa sorte á {nomeHeroi}!\nQue o jogo Comece!!");
            Console.ReadKey();
            Console.Clear();
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
            int ataque = random.Next(1, 11);
            vidaMonstro -= ataque;
            Console.WriteLine("\tO monstro foi danificado e perdeu {0} pontos de saúde e agora tem {1} pontos de saúde.", ataque, vidaMonstro);
        }

        private void AtaqueMonstro()
        {
            int ataque = random.Next(1, 11);
            vidaHeroi -= ataque;
            Console.WriteLine("\tO herói foi danificado e perdeu {0} pontos de saúde e agora tem {1} pontos de saúde.", ataque, vidaHeroi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            game.IniciarJogo();
            Console.ReadLine();

        }
    }
}
