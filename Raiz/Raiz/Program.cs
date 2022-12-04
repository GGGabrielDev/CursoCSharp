using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** Descubra a Raiz Quadrada de um número ******************\n");
            Console.Write("Entre com o valor de um número para calcular a Raíz: ");
            double x = double.Parse(Console.ReadLine());
            double a = Math.Sqrt(x);
            Console.WriteLine("\nO valor da Raíz Quadrada de " + x + " = " + a);
            Console.WriteLine("\nPressione Enter para sair !!!");

            Console.ReadLine();


        }
    }
}
