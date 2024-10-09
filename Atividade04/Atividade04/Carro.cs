namespace Atividade04
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Velocidade { get; set; }

        public int Desacelerar { get; set; }

        public Carro(string marca, string modelo, int velocidade, int desacelerar)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
            Desacelerar = desacelerar;
        }

        public void Acelerar()
        {
            Console.WriteLine($"Sua velocidade é {Velocidade} km/h");
        }

        public void Desacelerar1()
        {
            Console.WriteLine($"É necessario que você desacelere {Velocidade} km/h");
        }
    }
}
