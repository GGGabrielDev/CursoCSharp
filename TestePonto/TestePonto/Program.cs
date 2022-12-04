using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TestePonto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double x = 10.35784;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
            

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F5", CultureInfo.InvariantCulture));


            Console.ReadLine();
            */

            double x = 10.35784;

            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais ");
            Console.WriteLine("O valor do troco é" + x.ToString(" F2 ")+ "reais");

            Console.ReadLine();

        }
    }
}
