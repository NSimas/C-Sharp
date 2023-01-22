using System;
using Caneta0002;

namespace Caneta0002
{
    class Program
    {
        static void Main(string[] args)
        {
            Caneta caneta1 = new Caneta("Preto", "Cinza Claro", "Steadler", "Pinn 2023");

            Caneta caneta2 = new Caneta("Vermelho", "Transparente", "Pelican", "Fine Line 2022");

            foreach (PropertyInfo propriedade in caneta1.GetType().GetProperties())
            {
                Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(caneta1)}");
            }

            foreach (PropertyInfo propriedade in caneta2.GetType().GetProperties())
            {
                Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(caneta2)}");
            }
        }
    }
}