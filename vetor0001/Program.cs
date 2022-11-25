decimal[] notasAluno = new decimal[4];

Console.WriteLine("Digite a nota 1: ");
notasAluno[0] = decimal.TryParse(Console.ReadLine());

Console.WriteLine("Digite a nota 2: ");
notasAluno[1] = decimal.TryParse(Console.ReadLine());

Console.WriteLine("Digite a nota 3: ");
notasAluno[2] = decimal.TryParse(Console.ReadLine());

Console.WriteLine("Digite a nota 4: ");
notasAluno[3] = decimal.TryParse(Console.ReadLine());

decimal media = (notasAluno[0] + notasAluno[1] + notasAluno[2] + notasAluno[3]) / 4;

Console.WriteLine($"A média do aluno é {media}");