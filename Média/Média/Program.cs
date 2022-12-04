using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, media;

            Console.WriteLine("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;
            Console.WriteLine();
            Console.WriteLine("A Média é: " + media);
            Console.WriteLine("Pressione Enter para sair");

            Console.ReadLine();
        }
    }
}
