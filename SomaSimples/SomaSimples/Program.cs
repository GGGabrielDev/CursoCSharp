using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine("SOMA = " + soma);
            Console.WriteLine("\nPressione Enter para sair!!!");

            Console.ReadLine();
        }
    }
}
