using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoSimplesProd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double prod = a * b;
            Console.WriteLine("PROD = " + prod);
            Console.WriteLine("\nPressione para sair!!!");

            Console.ReadLine();

        }
    }
}
