using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoDoWhileTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char repetir;

            do
            {
                Console.WriteLine("Digite a Temperatura em Celsius");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir s/n? ");
                repetir = char.Parse(Console.ReadLine());
                Console.ReadLine();
            } while (repetir == 's');


            
        }
    }
}
