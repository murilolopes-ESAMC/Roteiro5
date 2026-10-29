namespace Exercicio3;

public class Produto
{
    public string Nome { get; }
    public decimal Preco { get; }
    public int Quantidade { get; }

    public decimal Total
    {
        get { return Preco * Quantidade; }
    }

    public Produto(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
}
