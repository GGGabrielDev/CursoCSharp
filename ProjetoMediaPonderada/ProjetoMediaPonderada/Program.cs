using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoMediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, media, p1 = 3.5, p2 = 7.5;

            a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            media = ((a * p1) + (b * p2)) / 11;
            Console.WriteLine("\nA média do aluno é:" + media.ToString("F5", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
