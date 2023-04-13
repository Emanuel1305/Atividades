using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CALCULA A MÉDIA GERAL DE UMA TURMA DE ALNOS
            Console.WriteLine("\t\t---Calcular a Média Geral de uma Turma de alunos---\n");

            //RECEBE A QUANTIDADE DOS ALUNOS QUE A TURMA POSSUI E O ARMAZENA EM UMA VARIÁVEL
            Console.Write("Qual o número de alunos que a turma possui: ");
            int num = int.Parse(Console.ReadLine());
            Limpar();

            //CRIA UMA VARIAVEL CONT, MSG (MENSAGEM) E UMA PARA ARMAZENAR A MÉDIA DA TURMA
            int cont = 1;
            string msg = "";
            double mediaturma = 0;

            while (cont <= num)
            {
                //RECEBE O NOME DE CADA ALUNO
                Console.Write("Iforme o nome do aluno: ");
                string nome = Console.ReadLine();

                int caracteres = nome.Length; //CALCULA A QUANTIDADE DE CARACTERES QUE CADA NOME POSSUI

                msg += nome; //ARMAZENA TODOS OS NOMES NA MESMA VARIAVEL

                Console.Write($"\nInforme a nota do {cont}° Aluno: "); //RECEBE O NOME DE CADA UM DOS ALUNOS

                //ARMAZENA A NOTA DE CADA BIMESTRE DE CADA ALUNO
                Console.Write("\n1° Bimestre: ");
                double m1 = double.Parse(Console.ReadLine());
                Console.Write("2° Bimestre: ");
                double m2 = double.Parse(Console.ReadLine());
                Console.Write("3° Bimestre: ");
                double m3 = double.Parse(Console.ReadLine());
                Console.Write("4° Bimestre: ");
                double m4 = double.Parse(Console.ReadLine());

                double mediaaluno = (m1 + m2 + m3 + m4) / 4; //CALCULA A MEDIA DE CADA ALUNO

                mediaturma += mediaaluno; //JUNTA A MÉDIA DE TODOS OS ALUNOS

                //CONCERTA A TABULAÇÃO DE ACORDO COM O NÚMERO DE CARACTERES DE CADA NOME
                if (caracteres > 7)
                {
                    msg += "\t\tMédia: " + mediaaluno + "\n";
                }
                else
                {
                    msg += "\t\t\tMédia: " + mediaaluno + "\n";
                }

                caracteres = 0; //RESETA O NÚMERO DE CARACTERES PARA RECERBER O DO PRÓXIMO ALUNO
                cont++; //ADICIONA +1 AO CONT
                Limpar(); //LIMPA O CÓDIGO
            }

            //CALCULA A MÉDIA DA TURMA E FORMATA PARA QUE SÓ TENHA 2 CARACTERES DEPOIS DA VIRGULA
            mediaturma = mediaturma / num;
            string mf = mediaturma.ToString("N2");

            //IMPRIME AO USUARIO TODAS AS INFORMAÇÕES ARMAZENADAS
            Console.Write(msg + $"\nA Média geral da turma foi: {mediaturma}");
            Console.ReadKey();

        }

        //CRIA UMA FUNÇÃO QUE LIMPA O CÓDIGO E MANTEM O TITULO 
        static void Limpar()
        {
            Console.Clear();
            Console.WriteLine("\t\t---Calcular a Média Geral de uma Turma de alunos---\n");
        }
    }
}
