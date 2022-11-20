using System;

public class OperadoresUnarios
{
	public OperadoresUnarios()
	{
		var X = false;
		var n1 = 6;
		var n2 = 3;
		var n3 = 8;
		var n4 = 5;

		Console.WriteLine(!X);
		n3++;
		Console.WriteLine(X);
		Console.WriteLine(n3);
		n4--;
		Console.WriteLine(n4);

		Console.WriteLine(n2 == --n1);
		Console.WriteLine(n2-- == ++n1);
	}
}
