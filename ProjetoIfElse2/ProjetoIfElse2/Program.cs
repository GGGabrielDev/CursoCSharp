using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("\nMENOR = " + x);

            }
            else
            {
                if (y < z)
                {
                    Console.WriteLine("\nMENOR = " + y);
                   
                }
                else
                {
                    Console.WriteLine("\nMENOR = " + z);

                }
            }
            Console.ReadLine();
        }
    }
}
