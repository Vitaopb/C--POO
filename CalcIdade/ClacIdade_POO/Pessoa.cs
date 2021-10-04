using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClacIdade_POO
{
   public class Pessoa
    {
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        private String nome;

        public String Nome
        {
            get {
                CalcIdade();
                return nome; 
            }
        }

        // Update
        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private void CalcIdade()
        {
            DateTime data = DateTime.Now;
            int anoAtual = data.Year;
            this.idade = anoAtual - AnoNascimento;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Ano de nascimento: {AnoNascimento}");
            CalcIdade();
            Console.WriteLine($"Idade: {Idade}"); 
        }
    }
}
