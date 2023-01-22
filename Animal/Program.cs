using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mamifero leao = new Mamifero("Léo", new DateTime(2020, 10, 28), 'm', true, false, 8, true, "caramelo")
            {
            };
            //métodos herdados de Animal
            leao.Idade();
            leao.Movimentar();
            leao.Comunicar();
            leao.Alimentar();

            //leão não amamenta, só leoas.

            Mamifero chacal = new Mamifero("Chica", new DateTime(2021, 12, 12), 'f', true, false, 8, true, "bege")
            {
            };

            //métodos herdados de Animal
            chacal.Idade();
            chacal.Movimentar();
            chacal.Comunicar();
            chacal.Alimentar();

            //método próprio de Mamifero
            chacal.Amamentar();

            Mamifero elefante = new Mamifero("Eloá", new DateTime(1975, 02, 04), 'f', false, false, 2, false, "cinza")
            {
            };

            //métodos herdados de Animal
            elefante.Idade();
            elefante.Movimentar();
            elefante.Comunicar();
            elefante.Alimentar();

            //método próprio de Mamifero
            elefante.Amamentar();
        }
    }
}