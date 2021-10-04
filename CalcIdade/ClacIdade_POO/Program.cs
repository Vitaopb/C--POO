using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClacIdade_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calc Year - POO");
            Pessoa p = new Pessoa();
            Console.Write("Qual o seu nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite seu ano de nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.Idade);

            Console.ReadKey();
        }
    }
}
