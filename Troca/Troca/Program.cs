using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troca
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, auxiliar;

            Console.WriteLine("Entre com o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            auxiliar= a;
            Console.WriteLine("Entre com o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            a = b;
            b = auxiliar;
            Console.WriteLine();
            Console.WriteLine("O valor de A é: " + a);
            Console.WriteLine("O valor de B é: " + b);
            Console.WriteLine();
            Console.WriteLine("Pressione Enter para sair!!!");

            Console.ReadLine();
           

        }
    }
}
