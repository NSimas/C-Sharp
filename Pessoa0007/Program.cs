using System;

namespace Pessoa0007
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Eduarda", 15);

            pessoa1.Cumprimentar();
            pessoa1.DizerIdade();

            Aluno pessoa2 = new Aluno("Vanda", 13);

            pessoa2.Cumprimentar();
            pessoa2.DizerIdade();
            pessoa2.IrParaEscola();

            Professor pessoa3 = new Professor("Joana", 43);

            pessoa3.Cumprimentar();
            pessoa3.DizerIdade();
            pessoa3.Explicar();
        }
    }
}