using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Lontra : Mamifero, IAquatico
    {
        //delcaração das propriedades de IAquatico
        public bool viveEmTerra { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }

        //construtor com as propriedades de Mamifero que vem de Animal e do IAquatico
        public Lontra (string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, 
            bool peconhento, int quantidadeDeMamas, bool pelos, string corDoPelo, 
            bool viveEmTerra, bool mergulho, bool aguaDoce) : base (nome, dataDeNascimento, 
                sexo, carnivoro, peconhento, quantidadeDeMamas, pelos, corDoPelo)
        {
            this.viveEmTerra = viveEmTerra;
            this.mergulho = mergulho;
            this.aguaDoce = aguaDoce;
        }
    }
}
