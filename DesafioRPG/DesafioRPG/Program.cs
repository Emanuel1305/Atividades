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
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Para embarcar nessa incrivel jorada, Informe o nome que seu valoroso herói carregará!\n");
            Console.Write("Nome: ");
            nomeHeroi = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\t\t---DESAFIO RPG---\n\t\t---Tela Iicial ---\n");
            Console.WriteLine("====================================================================================================");
            Console.WriteLine($"O nome do seu Herói foi definido!\nDesejamos boa sorte á {nomeHeroi}!\nAperte Qualquer tecla para continuar. Que o jogo Comece!!");
            Console.WriteLine("====================================================================================================");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t\t*** O jogo começou!! ***\n\n" +
                "====================================================================================================\n");

            while (vidaHeroi > 0 && vidaMonstro > 0)
            {
                AtaqueHeroi();
                if (vidaMonstro <= 0) break;
                AtaqueMonstro();
            }

            if (vidaHeroi > 0)
            {
                Console.WriteLine("====================================================================================================");
                Console.WriteLine("\n\t\t*** {0} venceu! ***", nomeHeroi);
            }
            else
            {
                Console.WriteLine("====================================================================================================");
                Console.WriteLine("\n\t\t*** O monstro venceu! ***");
            }

            Console.WriteLine("\t\t--- O jogo acabou! ---");
        }

        private void AtaqueHeroi()
        {
            int ataque = random.Next(1, 11);
            vidaMonstro -= ataque;
            Console.WriteLine($"\tO mostro é surpreendido e perde {ataque} pontos de sua vitalidade\n\tAgora lhe resta {vidaMonstro}/10!\n");
        }

        private void AtaqueMonstro()
        {
            int ataque = random.Next(1, 11);
            vidaHeroi -= ataque;
            Console.WriteLine($"\t{nomeHeroi} recebe um poderoso ataque e perde {ataque} pontos de sua vitalidade\n\tAgora lhe resta {vidaHeroi}/10!\n");
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
