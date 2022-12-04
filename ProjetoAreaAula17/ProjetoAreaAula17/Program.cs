using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoAreaAula17
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double triangulo = (a * c) / 2.0;
            double circulo =  pi * (c * c);
            double trapézio = (c * (a + b)) / 2.0;
            double quadrado = b * b;
            double retangulo = a * b;
            Console.WriteLine("\nTRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + trapézio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();



        }
    }
}
