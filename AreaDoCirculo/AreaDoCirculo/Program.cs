using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = pi * (raio * raio);
            Console.WriteLine("O valor do raio é: " + area.ToString("F4"));

            
            Console.ReadLine();



        }
    }
}
