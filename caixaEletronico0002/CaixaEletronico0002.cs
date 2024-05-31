using System.Globalization;
using System.ComponentModel.Design;
using System.Linq.Expressions;

public class CaixaEletronico0002
{
    public static void Main(string[] args)
    {
        int depositar = 0, valor = 0, opcoes = 0;

        while (opcoes != 3)
        {
            opcoes = Menu();
            Console.Clear();

            switch (opcoes)
            {
                case 1:
                    Sacar(valor);
                    break;

                case 2:
                    Depositar(depositar);
                    break;

                case 3:
                    Console.WriteLine("encerrando programa");
                    break;

            }
            Console.ReadKey();
        }

        int Menu()

        {
            Console.WriteLine("MENU DE OPÇÕES ");
            Console.WriteLine("=====================");
            Console.WriteLine("[1] SACAR");
            Console.WriteLine("[2] DEPOSITAR");
            //Console.WriteLine("[3] REALIZAR OUTRA OPERAÇÃO");
            Console.WriteLine("[3] Sair");

            int opcoes = int.Parse(Console.ReadLine());
            return opcoes;
        }

        Console.ReadKey();

        static void Sacar(int valor)
        {
            int retirar;

            Console.WriteLine("Digite um valor para ser sacado");

            retirar = int.Parse((string)Console.ReadLine());

            if (retirar == 0)
            {
                Console.WriteLine("Saldo invalido");
            }

            else if (retirar >= 1)
            {
                Console.WriteLine("retire as notas");
            }

            Console.ReadKey();
        }

        static void Depositar(int depositar)
        {



            Console.WriteLine("digite um valor");
            int dep = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor");
            int dep2 = int.Parse(Console.ReadLine());

            int saldo = dep + dep2;
            for (int i = 0; dep < i; i++)
            {
                Console.WriteLine("seu saldo é " + dep);

            }
            Console.ReadLine();




        }
    }
}