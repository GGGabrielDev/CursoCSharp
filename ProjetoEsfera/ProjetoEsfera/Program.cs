using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Entre com o valor de raio: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = (4/3.0) * pi*(raio * raio * raio);
            Console.WriteLine("\nvolume de uma esfera é: " + volume.ToString("F3"));

            Console.ReadLine();


        }
    }
}
