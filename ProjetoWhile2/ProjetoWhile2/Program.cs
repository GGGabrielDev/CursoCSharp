using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 5)
            {
                int y = x * 3;
                Console.Write(y);
                x = x + 1;
            }
            Console.WriteLine("FIM");
            Console.ReadLine();
        }
    }
}
