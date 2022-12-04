using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoGastoDeCombustível
{
    class Program
    {
        static void Main(string[] args)
        {
            const int kmL = 12;
            double tempoGV, velocMedia, kmL2, litros;

            tempoGV = double.Parse(Console.ReadLine());
            velocMedia = double.Parse(Console.ReadLine());
            kmL2 = velocMedia / kmL;
            litros = kmL2 * tempoGV;
            Console.WriteLine("\nPara realizar a viagem, precisa de: " + litros.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
