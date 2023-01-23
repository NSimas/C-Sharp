using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public abstract class Smartphone
    {
        public string numero;
        public string modelo;
        public string imei;
        public int memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public abstract void Ligar();
        public abstract void ReceberLigacao();
        public abstract void InstalarAplicativo(string nome);
    }
}
