using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoSplitFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o seu nome completo: ");
            string nomeC = Console.ReadLine();
            Console.Write("Quantos quartos tem sua casa? ");
            int numC = int.Parse(Console.ReadLine());
            Console.Write("Entre com o preço do produto: ");
            double precoP = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Entre com seu último nome, idade e altura: \n");
            string[] info = Console.ReadLine().Split(' ');

            string nome = info[0];
            int idade = int.Parse(info[1]);
            double altura = double.Parse(info[2],CultureInfo.InvariantCulture);

            Console.WriteLine("\nVocê digitou: \n");
            Console.WriteLine(nomeC);
            Console.WriteLine(numC);
            Console.WriteLine(precoP.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
