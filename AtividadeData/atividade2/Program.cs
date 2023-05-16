using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data de nascimento (DD/MM/AAAA): ");
            string dataNascimentoStr = Console.ReadLine();

            // Converter a string para um objeto DateTime
            DateTime dataNascimento;
            if (DateTime.TryParseExact(dataNascimentoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
            {
                // Calcular a idade
                int idade = CalcularIdade(dataNascimento);

                // Exibir a idade
                Console.WriteLine("A idade é: " + idade);
            }
            else
            {
                Console.WriteLine("Data de nascimento inválida.");
            }
        }

        static int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;

            // Verificar se ainda não fez aniversário neste ano
            if (dataAtual < dataNascimento.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }
    }
}
