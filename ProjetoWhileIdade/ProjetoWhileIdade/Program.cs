using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoWhileIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            soma = 0.0;
            cont = 0;

            while (idade >= 0)
            {
                soma += idade;
                cont += 1;
                idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            if (cont <= 0)
            {
                Console.WriteLine("\nImpossível de calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine("\n" + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
