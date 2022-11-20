internal class Program
{
    private static void Main(string[] args)
    {
        // vendo a estrutura de escolha Switch
        Console.WriteLine("Você ficou satisfeito? 1 para sim, 2 para não e 3 para talvez/não sei: ");
        
            int.TryParse(Console.ReadLine(), out int nota);

        switch (nota)
        {
            case 1:
                Console.WriteLine("Agradecemos muito pela satisfação!");
                break;
            case 2:
                Console.WriteLine("Pedimos desculpas!");
                break;
            case 3:
                Console.WriteLine("Iremos trabalhar para melhorar!");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}