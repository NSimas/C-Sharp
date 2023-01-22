using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Ave : Animal
    {
        public bool rapina { get; set; }
        public string corDasPenas { get; set; }

        public Ave(string nome, DateTime dataDeNascimento, char sexo, 
            bool carnivoro, bool peconhento, bool rapina, 
            string corDasPenas) : base (nome, dataDeNascimento, sexo, 
                carnivoro, peconhento)
        {
            this.rapina = rapina;
            this.corDasPenas = corDasPenas;
        }

        public void Ciscar()
        {
            Console.WriteLine(this.nome + " está ciscando!");
        }
    }
}
