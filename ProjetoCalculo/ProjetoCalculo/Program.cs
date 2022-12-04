using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double B, altura, area, perimetro, diagonal;

            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = B * altura;
            perimetro = 2 * (B + altura);
            diagonal = Math.Sqrt(Math.Pow(B,2.0) + Math.Pow(altura,2.0));

            Console.WriteLine("\nO valor da área é: " + area.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("\nO valor do perímetro é: " + perimetro.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("\nO valor da diagonal é: " + diagonal.ToString("F4",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
