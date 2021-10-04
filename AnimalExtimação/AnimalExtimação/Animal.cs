using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExtimação
{
    public class Animal
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _tipo;

        public string Tipo
        { // Valores definidos pelo propietario
            get { return _tipo; }
            set { 
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    _tipo = value;
                }
                else
                {
                    _tipo = "Peixe";
                }
            }
        }
    }
}
