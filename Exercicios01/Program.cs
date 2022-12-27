/*Faça um programa que recebe uma frase 
 * e substitui todas as ocorrências de 
 * espaço por “#”. Mostre o resultado 
 * no console.*/

using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string frase = "O amigo de fulano foi passear.";

        frase = frase.Replace(" ", "#");

        Console.WriteLine(frase);
    }
}