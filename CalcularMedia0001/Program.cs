public class CalcularMedia0001
{
    static void Main(string[] args)
    {
        float media = 0;

        Console.WriteLine("Bem-vindo ao cálculo de média!");
        Console.WriteLine("Vamos calcular a média do aluno!");

        Console.WriteLine("Digite a primeira nota: ");
        int.TryParse(Console.ReadLine(), out int nota1);

        Console.WriteLine("Digite a segunda nota: ");
        int.TryParse(Console.ReadLine(), out int nota2);

        Console.WriteLine("Digite a terceira nota: ");
        int.TryParse(Console.ReadLine(), out int nota3);

        Console.WriteLine("Digite a quarta nota: ");
        int.TryParse(Console.ReadLine(), out int nota4);

        media = (nota1+nota2+nota3+nota4) /4;
        Console.WriteLine("A média do aluno foi: {0}", media);

        if(media <7)
        {
            Console.WriteLine("O aluno está em recuperação.");
        }
        else
        {
            Console.WriteLine("Aluno aprovado!");
        }
    }
}