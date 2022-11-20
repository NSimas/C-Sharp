// aprendendo métodos construtores em C#
class Carro
{
    public string Nome;
    public string Marca;
    public double Potencia;

    public Carro(string nome, string marca, double potencia)
    {
        Nome = nome;
        Marca = marca;
        Potencia = potencia;
    }

    public Carro()
    {
    }
    class Construtor
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.Nome = "Golf";
            carro.Marca = "VolksWagen";
            carro.Potencia = 1.6;
            Console.WriteLine($"{carro.Nome} {carro.Marca} {carro.Potencia}");

            var carro2 = new Carro();
            carro2.Nome = "HB20";
            carro2.Marca = "Hyundai";
            carro2.Potencia = 1.4;
            Console.WriteLine(carro2);

            var carro3 = new Carro("Celta", "Chevrolet", 1.2);
            Console.WriteLine($"{carro3.Nome} {carro3.Marca} {carro3.Potencia}");
        }
    }
}