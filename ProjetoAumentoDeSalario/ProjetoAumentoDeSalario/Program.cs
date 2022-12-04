using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoAumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double percentual;

            if (salario <= 400)
            {
                percentual = 15.0;
            }
            else if (salario <= 800)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }
            double reajuste = salario * percentual / 100.0;
            double novosalario = salario + reajuste;

            Console.WriteLine("\nNovo Salário: " + novosalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste Ganho:" + reajuste.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();



        }
    }
}
