using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int horainicial = int.Parse(vet[0]);
            int horafinal = int.Parse(vet[1]);

            int duracao;
            if (horainicial < horafinal)
            {
                duracao = horafinal - horainicial;
            }
            else
            {
                duracao = 24 - horainicial + horafinal;
            }
            Console.WriteLine("O Jogou durou " + duracao + "hora(s)");
            Console.ReadLine();
        }
    }
}
