using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoDistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de x1: ");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor de y1: ");
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor de x2: ");
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor de y2: ");
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt((((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));

            Console.WriteLine("\nO valor da distância é: " + distancia.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();




        }
    }
}
