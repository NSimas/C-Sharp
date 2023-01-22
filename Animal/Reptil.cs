using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Reptil : Animal
    {
        public bool temEscamas { get; set; }
        public bool temCasco { get; set; }
        public Reptil (string nome, DateTime dataDeNascimento, 
            char sexo, bool carnivoro, bool peconhento, bool temEscamas, 
            bool temCasco) : base (nome, dataDeNascimento, sexo, 
                carnivoro, peconhento)
        {
            this.temEscamas = temEscamas;
            this.temCasco = temCasco;
        }
    }
}
