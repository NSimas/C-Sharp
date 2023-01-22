using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Arara : Ave, IVoar, IOviparo
    {
        //declaração das novas propriedades compostas pela IVoar
        public int altitudeMaximaDeVoo { get; set; }
        public double velocidadeDeVoo { get; set; }

        //todas as propriedades de ave, animal, IVoar e IAquatico
        public Arara (string nome, DateTime dataDeNascimento, char sexo, bool carnivoro,
        bool peconhento, bool rapina, string corDasPenas, int altitudeMaximaDeVoo,
        double velocidadeDeVoo) : base(nome, dataDeNascimento, sexo, carnivoro,
        peconhento, rapina, corDasPenas)
        {
            this.altitudeMaximaDeVoo = altitudeMaximaDeVoo;
            this.velocidadeDeVoo = velocidadeDeVoo;
        }

        //método da IVoar
        public void Voar()
        {
            Console.WriteLine(this.nome + " está voando!");
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
