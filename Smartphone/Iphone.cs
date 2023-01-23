using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public class Iphone : Smartphone
    {
        string nome;
        //declaração das propriedades já feita na classe abstrata Smartphone

        //construtor
        public Iphone(string numero, string modelo, string imei, 
            int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        //métodos 
        public override void Ligar()
        {
            Console.WriteLine("Estou ligado!");
        }
        public override void ReceberLigacao()
        {
            Console.WriteLine("Estou recebendo uma ligação");
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Qual app da APP STORE você vai instalar?");
            string app = Console.ReadLine();
            Console.WriteLine("Você instalou " + app + " com sucesso!");
        }

    }
}
