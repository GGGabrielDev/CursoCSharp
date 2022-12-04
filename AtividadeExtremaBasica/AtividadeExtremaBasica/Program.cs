using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeExtremaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            double x = a + b;
            Console.WriteLine("\nX = " + x);
            Console.Write("\nEntre com o primeiro valor: ");
            double aa = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo valor: ");
            double bb = double.Parse(Console.ReadLine());
            double xx = aa + bb;
            Console.WriteLine("\nX = " + xx);
            Console.Write("\nEntre com o primeiro valor: ");
            double aaa = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o segundo valor: ");
            double bbb = double.Parse(Console.ReadLine());
            double xxx = aaa - bbb;
            Console.WriteLine("\nX = " + xxx);
            Console.WriteLine("\nPressione Enter para sair!!!");


            Console.ReadLine();


        }
    }
}
