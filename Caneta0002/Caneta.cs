using System;


namespace Caneta0002
{
    public class Caneta
    {
        public string _corTinta { get; set; }
        public string _corDoCorpo { get; set; }
        public string _marca { get; set; }
        public string _modelo { get; set; }

        public Caneta(string corTinta, string corCorpo, string marca, string modelo)
        {
            _corTinta = corTinta;
            _corDoCorpo = corCorpo;
            _marca = marca;
            _modelo = modelo;
        }
    }
}
