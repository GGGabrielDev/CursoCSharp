using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoLanche
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, precofinal = 0.0;
            string[] vet = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vet[0],CultureInfo.InvariantCulture);
            int quantidade = int.Parse(vet[1],CultureInfo.InvariantCulture);

            if (codigo == 1)
            {
                precofinal = 4.00 * quantidade;
            }
            else if (codigo == 2)
            {
                precofinal = 4.50 * quantidade;
            }
            else if (codigo == 3)
            {
                precofinal = 5.00 * quantidade;
            }
            else if (codigo == 4)
            {
                precofinal = 2.00 * quantidade;
            }
            else if (codigo == 5)
            {
                precofinal = 1.50 * quantidade;
            }
            else
            {
                Console.WriteLine("\nCódigo Inválido");
            }

            Console.WriteLine("Total R$:" + precofinal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
