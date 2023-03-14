using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 03
            Console.Write("\t-----MÉDIA DAS IDADES DE 5 ALUNOS-----\t\n\n");
            Console.Write("Idade do primeiro aluno: ");
            int idade1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade do segundo aluno: ");
            int idade2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade do terceiro aluno: ");
            int idade3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade do quarto aluno: ");
            int idade4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Idade do quinto aluno: ");
            int idade5 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("\t-----MÉDIA DAS IDADES-----\t\n\n");
            Console.Write($"A Média das idades dos 5 alunos é =\t{(idade1 + idade2 + idade3 + idade4 + idade5) / 5}");

            Console.ReadKey();



        }
    }
}
