using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioImparesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int min, max;
            if (X < Y)
            {
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }
            int soma = 0;
            for(int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + 1;
                }

                Console.WriteLine(soma);

            }
            Console.ReadLine();



        }
    }
}
