// Calculadora que vai somando...
bool opcao = true;

Console.WriteLine("Sou a calculadora de soma e vou somar os números =D");
Console.WriteLine("Digite o primeiro número: ");
float.TryParse(Console.ReadLine(), out float n1);

while (opcao = true)
{
    Console.WriteLine("Digite o número a somar:");
    float.TryParse(Console.ReadLine(), out float n2);
    n1 = n1 + n2;
    Console.WriteLine("O total da soma até aqui é: {0}", n1);
    Console.WriteLine("Quer sair da soma? 1 - Sim / 2 - Não");
    int.TryParse(Console.ReadLine(), out int saida);
    switch (saida)
    {
        case 1:
            Console.WriteLine("Obrigada! Saindo...");
            opcao = false;
            break;
        case 2:
            Console.WriteLine("Seguiremos com a soma.");
            break;
        default:
            Console.WriteLine("Opção inválida, voltaremos pra soma...");
            break;
    }
}