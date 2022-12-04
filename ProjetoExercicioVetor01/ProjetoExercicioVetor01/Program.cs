using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoExercicioVetor01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N =int.Parse(Console.ReadLine());
            vet = new double[6];

            for(int i = 0; i < N; i++)
            {
                vet[i]=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            for (int i = N; i <= N; i++)
            {
                double maxValue = vet.Max();
                int maxIndex = vet.ToList().IndexOf(maxValue);

                Console.WriteLine("\n"+maxValue.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine(maxIndex);
            }
                Console.ReadKey();

        }
    }
}
