using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoSalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do vendedor? ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nInforme seu sálario fixo: ");
            double salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme seu total de vendas: ");
            double totalDeVendas = double.Parse(Console.ReadLine());
            double salarioComBonus = salarioFixo + (totalDeVendas * 0.15);
            Console.WriteLine("\nO seu sálario com bônus é: " + salarioComBonus.ToString("F2"));

            Console.ReadLine();



        }
    }
}
