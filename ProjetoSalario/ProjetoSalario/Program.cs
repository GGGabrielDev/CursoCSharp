using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double numFun, horaT, valorPH, salario;
            numFun = double.Parse(Console.ReadLine());
            horaT = double.Parse(Console.ReadLine());
            valorPH = double.Parse(Console.ReadLine());
            salario = horaT * valorPH;
            Console.WriteLine("\nNúmero do Funcionário: " + numFun);
            Console.WriteLine("Sálario: " + salario);

            Console.ReadLine();
        }
    }
}
