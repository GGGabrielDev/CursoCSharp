using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, soma2, resulSoma, sub, sub2, resulSub, multi, multi2, resulMulti, divi, divi2, resulDivi;

            Console.Write("Entre com o valor da soma: ");
            soma = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da soma: ");
            soma2 = double.Parse(Console.ReadLine());
            resulSoma = soma + soma2;
            Console.Write("Resultado da soma: " + resulSoma);
            Console.WriteLine();
            Console.WriteLine("\nPressione Enter para ir para a próxima conta!!!");
            Console.ReadLine();
            Console.Write("\nEntre com o valor da subtração: ");
            sub = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da subtração: ");
            sub2 = double.Parse(Console.ReadLine());
            resulSub = sub - sub2;
            Console.Write("Resultado da subtração: " + resulSub);
            Console.WriteLine();
            Console.WriteLine("\nPressione Enter para ir para a próxima conta!!!");
            Console.ReadLine();
            Console.Write("\nEntre com o valor da multiplicação: ");
            multi = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da multiplicação: ");
            multi2 = double.Parse(Console.ReadLine());
            resulMulti = multi * multi2;
            Console.WriteLine("Resultado da multiplicação: " + resulMulti);
            Console.WriteLine();
            Console.WriteLine("\nPressione Enter para ir para a próxima conta!!!");
            Console.ReadLine();
            Console.Write("\nEntre com o valor da divisão: ");
            divi = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da divisão: ");
            divi2 = double.Parse(Console.ReadLine());
            resulDivi = divi / divi2;
            Console.Write("Resultado da divisão: " + resulDivi);
            Console.WriteLine();
            Console.WriteLine("\nPressione Enter para sair!!!");

            Console.ReadLine();
        }
    }
}
