using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa0007
{
    public class Aluno : Pessoa
    {
        //propriedades do Aluno, baseado em Pessoa, passadas no construtor
        public Aluno(string nome, int idade) : base(nome, idade)
        {
            
        }

        public void IrParaEscola()
        {
            Console.WriteLine("\n Fui para a escola!!");
        }
    }
}
