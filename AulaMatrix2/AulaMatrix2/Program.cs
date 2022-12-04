using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;
            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(vet[j]);
                }
            }
            Console.WriteLine("\nDiagonal Principal: ");
            for(int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();
            int cont = 0;
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("\nQuantidade de Negativos = " + cont);
            Console.ReadKey();

        }
    }
}
