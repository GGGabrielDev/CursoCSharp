﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDeSelecao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0) 
            {
                Console.WriteLine("\nValores Aceitos");

            }

            else 
            {
                Console.WriteLine("\nValor Inválido");
            }
            Console.ReadLine();       
        }
    }
}
