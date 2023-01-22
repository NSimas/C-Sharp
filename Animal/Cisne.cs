using System;

namespace Animal
{
    public class Cisne : Ave, IVoar, IAquatico, IOviparo
    {
        //declaração das propriedades de IVoar
        public int altitudeMaximaDeVoo { get; set; }
        public double velocidadeDeVoo { get; set; }

        //delcaração das propriedades de IAquatico
        public bool viveEmTerra { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }

        //construtor com as propriedades de ave, animal, IVoar e IAquatico
        public Cisne (string nome, DateTime dataDeNascimento, char sexo, bool carnivoro,
            bool peconhento, bool rapina, string corDasPenas, int altitudeMaximaDeVoo, 
            double velocidadeDeVoo, bool viveEmTerra, bool mergulho, bool aguaDoce) : base (nome, dataDeNascimento, sexo, carnivoro, 
                peconhento, rapina, corDasPenas)
        {
            this.altitudeMaximaDeVoo = altitudeMaximaDeVoo;
            this.velocidadeDeVoo = velocidadeDeVoo;
            this.viveEmTerra = viveEmTerra;
            this.mergulho = mergulho;
            this.aguaDoce = aguaDoce;
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