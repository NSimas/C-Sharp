using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string frase = "Este Texto De Teste!";

        frase = frase.Replace(" ", "");

        Console.WriteLine(frase);
    }
}
