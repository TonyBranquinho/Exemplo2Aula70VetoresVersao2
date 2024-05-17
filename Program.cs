using Exemplo2Aula70VetoresVersao2;
using System;
using System.Globalization;
using System.Net;


namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o numero de produtos.");
            int n = int.Parse(Console.ReadLine());

            Product[] produtos = new Product[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do produto. ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto. ");
                double price = double.Parse(Console.ReadLine(), CI);
                produtos[i] = new Product { Name = name, Price = price };
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma = soma + produtos[i].Price;
            }

            double media = soma / n;
            Console.WriteLine("A media dos preços é de " + media.ToString("F2", CI));

        }
    }
}