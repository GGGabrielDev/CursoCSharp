using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoSplit2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] info = Console.ReadLine().Split(' ');

            string nome = info[0];
            char sexo = char.Parse(info[1]);
            int idade = int.Parse(info[2]);
            double altura =double.Parse(info[3],CultureInfo.InvariantCulture);

            Console.WriteLine("\nVocê digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
