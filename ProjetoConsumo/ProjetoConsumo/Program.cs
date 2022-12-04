using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoConsumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanciaTP, combustivelG, consumoM;
            distanciaTP = double.Parse(Console.ReadLine());
            combustivelG = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            consumoM = distanciaTP / combustivelG;
            Console.WriteLine("\nO consumo médio do automóvel é: " + consumoM.ToString("F3"),CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
