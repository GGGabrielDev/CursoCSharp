﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == o)
                {
                    Console.WriteLine("NULL");
                }
                else if (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }

                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }

                }

            }
            Console.ReadKey();


        }
    }
}
