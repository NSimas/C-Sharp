using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Jacare : Reptil, IAquatico, IOviparo
    {
        //delcaração das propriedades de IAquatico
        public bool viveEmTerra { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }

        //construtor com propriedades de Reptil que herda de Animal,
        //também as da composição com IAquatico
        public Jacare(string nome, DateTime dataDeNascimento, char sexo, 
            bool carnivoro, bool peconhento, bool temEscamas,
            bool temCasco, bool viveEmTerra, bool mergulho, 
            bool aguaDoce) : base(nome, dataDeNascimento, sexo, carnivoro, peconhento, temEscamas, temCasco)
        {
            this.viveEmTerra = viveEmTerra;
            this.mergulho = mergulho;
            this.aguaDoce = aguaDoce;
        }

        //métodos de IOviparo
        public void Botar()
        {
            Console.WriteLine(this.nome + " está pondo um ovo!");
        }

        public void Chocar()
        {
            Console.WriteLine(this.nome + "está chocando!");
        }
    }
}
