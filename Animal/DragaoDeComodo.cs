using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class DragaoDeComodo : Reptil, IOviparo
    {
        //construtor com as propriedades de Reptil que herda de Animal
        public DragaoDeComodo (string nome, DateTime dataDeNascimento, char sexo, 
            bool carnivoro, bool peconhento, bool temEscamas, bool temCasco) : base (nome, 
                dataDeNascimento, sexo, carnivoro, peconhento, temEscamas, temCasco)
        {
        }

        //métodos de IOviparo
        public void Botar()
        {
            Console.WriteLine(this.nome + " está pondo um ovo!");
        }

        public void Chocar()
        {
            Console.WriteLine(this.nome + "está chocando!");
        }

    }
}
