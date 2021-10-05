using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingGame_Console
{
    class Cenario
    {
        public string Chao { get; set; }

        public Byte Tamanho { get; set; }

        public Cenario(String chao, Byte tamaho)
        {
            Chao = chao;
            Tamanho = tamaho;
        }

        public void imprime(Player p)
        {
            Console.Clear();
            Console.WriteLine();

            // IMPRIME UMA LINHA
            if (p.Pulando)
            {
                for (Byte i = 0; i < p.Posicao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(p.Aparencia);
            }
            else
            {
                Console.WriteLine();
            }

            for (Byte i = 0; i < p.Posicao; i++)
            {
                Console.Write(Chao);
            }

            if (p.Pulando) Console.Write(Chao);
            else Console.Write(p.Aparencia);

            for (Byte i = 0; i < (Tamanho - p.Posicao); i++)
            {
                Console.Write(Chao);
            }
        }
    }
}
