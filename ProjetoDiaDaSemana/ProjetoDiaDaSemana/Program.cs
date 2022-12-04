using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDiaDaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "\nDia da Semana: Domingo";
                    break;
                case 2:
                    dia = "\nDia da Semana: Segunda-Feira";
                    break;
                case 3:
                    dia = "\nDia da Semana: Terça-Feira";
                    break;
                case 4:
                    dia = "\nDia da Semana: Quarta-Feira";
                    break;
                case 5:
                    dia = "\nDia da Semana: Quinta-Feira";
                    break;
                case 6:
                    dia = "\nDia da Semana: Sexta-Feira";
                    break;
                case 7:
                    dia = "\nDia da Semana: Sábado";
                    break;

                default:
                    dia = "\nValor Invalido";
                    break;

            }
            Console.WriteLine(dia);
            Console.ReadLine();
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*int diadasemana = int.Parse(Console.ReadLine());
            if (diadasemana == 1)

            {
                Console.WriteLine("\nDia da Semana: Domingo ");

            }
            else if (diadasemana == 2)
            {
                Console.WriteLine("\nDia da Semana: Segunda-Feira ");

            }
            else if (diadasemana == 3)
            {
                Console.WriteLine("\nDia da Semana: Terça-Feira ");
            }
            else if (diadasemana == 4)
            {
                Console.WriteLine("\nDia da Semana: Quarta-Feira ");
            }
            else if (diadasemana == 5)
            {
                Console.WriteLine("\nDia da Semana: Quinta-Feira ");
            }
            else if (diadasemana == 6)
            {
                Console.WriteLine("\nDia da Semana: Sexta-Feira ");
            }
            else if (diadasemana == 7)
            {
                Console.WriteLine("\nDia da Semana: Sábado ");
            }
            else
            {
                Console.WriteLine("\nValor inválido");
            }
            Console.ReadLine();*/

        }
    }
}
