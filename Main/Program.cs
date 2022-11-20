internal class Program
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            a1.Nome = "Zé";
            a1.Idade = 14;
            a1.Serie = 8;

            object aluno1 = null;
            Console.WriteLine($"0 aluno {a1.Nome} tem {a1.Idade} anos e pertence ao {a1.Serie} ano");
        }
    }
}