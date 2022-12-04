using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AuaVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for(int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                nomes[i] = S[0];
                idades[i] = int.Parse(S[1]);
                alturas[i] = double.Parse(S[2], CultureInfo.InvariantCulture);
            }
            double soma = 0.0 ;
            for (int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("\nAltura Média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            int cont = 0;

            for(int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
                
            }
            double porcentagem =(double)cont/N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture)+("%"));
            Console.ReadKey();
        }
    }
}
