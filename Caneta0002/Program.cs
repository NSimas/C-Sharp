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

            Console.WriteLine($caneta1 ," ", caneta2);
        }
    }
}