using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaPonderada2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,media, p1 = 2, p2 = 3, p3 = 5;
            a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            media = ((a * p1) + (b * p2) + (c * p3)) / 10;
            Console.WriteLine("\nA média do aluno é: " + media);

            Console.ReadLine();


        }
    }
}
