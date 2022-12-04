using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma = 0;
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n"+soma);
            Console.ReadLine();




        }
    }
}
