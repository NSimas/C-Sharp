Console.WriteLine("Digite tua nota: ");
double.TryParse(Console.ReadLine(), out double nota);

Console.WriteLine("Nota maior que 7? {0} ", nota > 7.0);
Console.WriteLine("Tirou 10? {0} ", nota == 10.0);