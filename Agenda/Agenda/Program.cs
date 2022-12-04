using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone;
            
            Console.WriteLine("Entre com o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com o Endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Entre com o Telefone: ");
            telefone = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu endereço é: " + endereco);
            Console.WriteLine("Seu telefone é: " + telefone);
            Console.WriteLine("Pressione Enter para sair!!!");
            Console.ReadLine();


        }
    }
}
