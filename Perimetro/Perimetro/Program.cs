using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseT, altura, perimetro, area;

            Console.WriteLine("Entre com a base: ");
            baseT = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura: ");
            altura = double.Parse(Console.ReadLine());
            perimetro = 2 * (baseT + altura);
            area = baseT + altura;
            Console.WriteLine("O perímetro do retângulo é: " + perimetro);
            Console.WriteLine("A área do retângulo é: " + area);
            Console.WriteLine();
            Console.WriteLine("Pressione Enter para sair!!!");

            Console.ReadLine();






        }
    }
}
