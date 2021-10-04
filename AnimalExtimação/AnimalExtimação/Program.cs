using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExtimação
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;
            string exit = "a";

                Console.WriteLine("Controle de animais!");
            while (exit != "Exit")
            {
                Console.Write("Informe o nome do animal: ");
                a1.Nome = Console.ReadLine();
                Console.Write("Informe o tipo do primeiro animal (Cachorro, gato ou Peixe): ");
                a1.Tipo = Console.ReadLine();

                if (a1.Tipo == "Cachorro") tlCachorro++;
                if (a1.Tipo == "Gato") tlGato++;
                if (a1.Tipo == "Peixe") tlPeixe++;

                Console.WriteLine($"Cachorros: {tlCachorro}");
                Console.WriteLine($"Gatos: {tlGato}");
                Console.WriteLine($"Peixes: {tlPeixe}");

            }
                
           
        }
    }
}
