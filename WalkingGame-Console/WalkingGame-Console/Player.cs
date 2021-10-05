
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingGame_Console
{
    class Player
    {

        public Byte Posicao { get; set; }
        public String Aparencia { get; set; }
        public String FacingRight { get; set; }
        public String FacingLeft { get; set; }
        public Boolean Pulando { get; set; }

        public Player(String right, String left)
        {
            Posicao = 0;
            FacingLeft = left;
            FacingRight = right;
            Aparencia = FacingRight;
            Pulando = false;
        }

        public void pula()
        {
            Console.Beep(234, 100);
        }

        public void anda(Boolean direcao, Byte limite)
        {
            if (direcao)
            {
                if (Posicao < limite)
                {
                    Posicao++;
                    Aparencia = FacingRight;
                }
                else
                {
                    Posicao--;
                    Aparencia = FacingLeft;
                }
            }
        }
    }
}
