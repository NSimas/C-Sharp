using System;


namespace Caneta0002
{
    public class Caneta
    {
        private string _corTinta;
        private string _corDoCorpo;
        private string _marca;
        private string _modelo;

        public Caneta(string corTinta, string corCorpo, string marca, string modelo)
        {
            _corTinta = corTinta;
            _corDoCorpo = corCorpo;
            _marca = marca;
            _modelo = modelo;
        }
    }
}
