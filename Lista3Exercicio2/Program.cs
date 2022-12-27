using System.Collections.Generic;

namespace Aulas;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[] { };

        foreach (int i in numeros)
        {
            try
            {
                Console.WriteLine("Digite um número inteiro =}");
                numeros.Append(Int32.Parse(Console.ReadLine()));
            }
            catch (Exception e) 
            {
                Console.WriteLine("Isso que tu digitou não é um número inteiro!");
            }
        }
        foreach (int i in numeros)
        {
            List listaPar = new List<int[]>();
            List listaImpar = new List<int[]>();

            if (listaPar.leght() < 5 || listaImpar.lenght() < 5)
            {
                Console.WriteLine("Digite um número inteiro que não seja zero.");
                numeroDigitado = Console.ReadLine();

                if (numeroDigitado % 2 == 0)
                {
                    listaPar.add(numeroDigitado);
                }
                else
                {
                    listaImpar.add(numeroDigitado);
                }
            }

            D = new Dictionary<int[], int[]>

            foreach (listaImpar.lenght < 5)
            {
                D.Add(listaPar, listaImpar);
            }
        }
    }

}