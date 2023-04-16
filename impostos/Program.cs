using Impostos.entities;
using System.Globalization;

namespace Impostos
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Individual or company: (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Anual Income: ");
                double rendaAnual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);   
                if (resp  == 'i' )
                {
                    Console.Write("Health expenditures: ");
                    double gastSaude = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome,rendaAnual,gastSaude));
                }
                else
                {
                    Console.Write("Number of Employee: ");
                    int funcionario = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaJuritica(nome,rendaAnual,funcionario));
                }
            }

            Console.WriteLine("\nTAXES PAID: ");

            foreach (Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.Nome + ": $ " + pessoa.ImpostaTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
