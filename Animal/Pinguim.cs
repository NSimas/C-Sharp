using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Pinguim : Ave, IOviparo, IAquatico
    {
        //delcaração das propriedades de IAquatico
        public bool viveEmTerra { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }

        //construtor com propriedades de Ave, que também herda de Animal e os de IAquatico
        public Pinguim (string nome, DateTime dataDeNascimento, 
            char sexo, bool carnivoro, bool peconhento, bool rapina, 
            string corDasPenas, bool viveEmTerra, bool mergulho, bool aguaDoce) : base (nome, dataDeNascimento, 
                sexo, carnivoro, peconhento, rapina, corDasPenas)
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
