using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeTanque
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;
            double pi = 3.1415;

            Console.WriteLine("Digite o primeiro valor: ");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            altura = double.Parse(Console.ReadLine());
            volume = pi * (raio * raio * altura);
            Console.WriteLine();
            Console.WriteLine("O volume do tanque de gasolina é: " + volume);
            Console.WriteLine();
            Console.WriteLine("Presione Enter para sair!");

            Console.ReadLine();
        }
    }
}