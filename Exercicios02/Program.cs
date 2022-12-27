/*Faça um programa que receba uma frase 
 * e retorne na tela a mesma frase 
 * sem os espaços.*/

using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase e a mesma terá seus espaços retirados!");
        string frase = Console.ReadLine();

        frase = frase.Replace(" ", "");

        Console.WriteLine(frase);
    }
}
