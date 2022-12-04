using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMatrix3
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;
            string[] S = Console.ReadLine().Split(' ');
            M = int.Parse(S[0]);
            N = int.Parse(S[1]);
            mat = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                S = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(S[j]);
                }

            }
            int[] vet = new int[M];
            for(int i = 0; i < M; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }
            Console.WriteLine();
            for(int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }
    }
}
