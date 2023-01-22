using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        //campos do Animal
        public string nome;
        public DateTime dataDeNascimento;
        public char sexo;
        public bool carnivoro;
        public bool peconhento;

        //construtor da classe
        public Animal (string nome, DateTime dataDeNascimento, 
            char sexo, bool carnivoro, bool peconhento)
        {
            this.nome = nome;
            this.dataDeNascimento = dataDeNascimento;
            this.sexo = sexo;
            this.carnivoro = carnivoro;
            this.peconhento = peconhento;
        }

        //métodos da classe
        public int Idade()
        {
            int anoAtual = DateTime.Now.Year;
            int anoNascimento = this.dataDeNascimento.Year;
            int idade = (anoAtual - anoNascimento);
            return idade;
        }

        public void Movimentar()
        {
            Console.WriteLine(this.nome + " está se movimentando!");
        }
        public void Comunicar()
        {
            Console.WriteLine(this.nome + " está se comunicando!");
        }
        public void Alimentar()
        {
            Console.WriteLine(this.nome + " está se alimentando!");
        }
    }
}
