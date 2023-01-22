using System;

namespace Animal
{
    public class Morcego : Mamifero, IVoar
    {
        //declaração das novas propriedades compostas pela IVoar
        public int altitudeMaximaDeVoo { get; set; }
        public double velocidadeDeVoo { get; set; }

        //todas as propriedades de Mamifero, que herda de animal e de IVoar
        public Morcego (string nome, DateTime dataDeNascimento, char sexo, bool carnivoro, bool peconhento, 
            int quantidadeDeMamas, bool pelos, string corDoPelo, int altitudeMaximaDeVoo, 
            double velocidadeDeVoo) : base (nome, dataDeNascimento, sexo, carnivoro, peconhento, 
                quantidadeDeMamas, pelos, corDoPelo)
        {
            this.altitudeMaximaDeVoo = altitudeMaximaDeVoo;
            this.velocidadeDeVoo = velocidadeDeVoo;
        }
        //método da IVoar
        public void Voar()
        {
            Console.WriteLine(this.nome + " está voando!");
        }
    }
}
