using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDistancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos, distancia;

            distancia = int.Parse(Console.ReadLine());
            minutos = distancia * 2;
            Console.WriteLine("\nLevará " + minutos + " minutos");

            Console.ReadLine();
        }
    }
}
