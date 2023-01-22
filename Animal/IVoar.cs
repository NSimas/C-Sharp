using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal interface IVoar
    {
        public int altitudeMaximaDeVoo { get; set; }
        public double velocidadeDeVoo { get; set; }

        public void Voar();
    }
}
