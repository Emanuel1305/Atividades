using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01 -
            Console.Write("\t-----DADOS DO USUÁRIO-----\t\n\n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Clear();
            Console.Write("\t-----DADOS DO USUÁRIO-----\t\n\n");
            Console.Write($"Nome =\t\t{nome}\nEndereço =\t{endereco}\nTelefone =\t{telefone}");
            Console.ReadKey();

        }
    }
}
