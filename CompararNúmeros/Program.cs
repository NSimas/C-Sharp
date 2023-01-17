/* exercício em C# para verificar qual dos três
* números digitados é o maior. */

using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("O maior número é o: " + numero1);
            }
            else if (numero2 > numero2)
            {
                Console.WriteLine("O maior número é o: " + numero2);
            }
            else
            {
                Console.WriteLine("O maior número é o: " + numero3);
            }
        }
    }
}