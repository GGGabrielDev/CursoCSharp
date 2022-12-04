using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            int anos = idade / 365;
            int resto = idade % 365;
            int meses = resto / 30;
            resto = resto % 30;
            int dias = resto / 1;

            Console.WriteLine("\n"+anos + " ano(s)");
            Console.WriteLine(meses + " mês(s)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadLine();


        }
    }
}
