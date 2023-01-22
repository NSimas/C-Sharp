using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa0007
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {

        }

        public void Explicar()
        {
            Console.WriteLine("\n Estou explicando um assunto!");
        }
    }
}
