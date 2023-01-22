using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Mamifero : Animal
    {
        public int quantidadeDeMamas { get; set; }
        public bool pelos { get; set; }
        public string corDoPelo { get; set; }

        public Mamifero(string nome, DateTime dataDeNascimento, char sexo, 
            bool carnivoro, bool peconhento, int quantidadeDeMamas, 
            bool pelos, string corDoPelo) : base (nome, dataDeNascimento, 
                sexo, carnivoro, peconhento)
        {
            this.quantidadeDeMamas = quantidadeDeMamas;
            this.pelos = pelos;
            this.corDoPelo = corDoPelo;
        }

        public void Amamentar()
        {
            Console.WriteLine(this.nome + " está amamentando!");
        }
    }
}
