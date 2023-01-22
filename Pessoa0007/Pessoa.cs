using System;
using System.Security.Cryptography.X509Certificates;

namespace Pessoa0007
{
    public class Pessoa
    {
        //propriedades da Pessoa
        public string nome;
        public int idade;

        //construtor da classe
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        //métodos
        public void Cumprimentar()
        {
            Console.WriteLine("\n Olá, meu nome é: " + this.nome + "!");
        }

        public void DizerIdade()
        {
            Console.WriteLine("\n Tenho " + this.idade + " anos!");

        }
    }
}
