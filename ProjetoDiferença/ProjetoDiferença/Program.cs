using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDiferença
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, diferenca;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            diferenca = (a * b) - (c * d);
            Console.WriteLine("DIFERENÇA: " + diferenca);

            Console.ReadLine();

        }
    }
}
