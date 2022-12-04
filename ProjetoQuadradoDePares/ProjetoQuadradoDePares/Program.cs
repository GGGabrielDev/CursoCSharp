using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuadradoDePares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            for(int i = 2; i <= n; i++)
            {
                int quadrado = i * i;
                Console.WriteLine(i + "^2= " + quadrado);

            }
            Console.ReadKey();
        }
        
    }
}
