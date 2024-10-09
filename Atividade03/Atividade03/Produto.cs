namespace Atividade03
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preço { get; set; }

        public int Estoque { get; set; }

        public Produto(int codigo, string nome, double preço, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preço = preço;
            Estoque = estoque;
        }

        public void valorEstoque()
        {
            Console.WriteLine($"{Estoque} unidades");
        }
    }
}
