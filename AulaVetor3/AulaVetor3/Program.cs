using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AulaVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] S = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < N; i++)
            {
                A[i] = double.Parse(S[i],CultureInfo.InvariantCulture);


            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            double soma = 0.0;
            for(int i = 0; i < N; i++)
            {
                soma += A[i];

            }
            double media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
