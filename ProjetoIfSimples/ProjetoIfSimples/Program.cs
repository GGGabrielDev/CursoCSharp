using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIfSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá que horas são: ");
            int horas = int.Parse(Console.ReadLine());
            if (horas <= 12)
            {
                Console.WriteLine("\nBom dia!!!");

            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("\nBom tarde!!!");

                    
                }
                else
                {
                    Console.WriteLine("\nBom noite!!!");

                }
            }
            Console.ReadLine();



        }
    }
}
