using System.Globalization;
using Exercicio3;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício 3 a): Tabela formatada ---");
Console.WriteLine();

List<Produto> produtos = new List<Produto>
{
    new Produto("Notebook", 3499.90m, 2),
    new Produto("Mouse sem fio", 89.50m, 15),
    new Produto("Cabo HDMI", 25m, 1200)
};

string cabecalho = string.Format("{0,-16}{1,14}{2,10}{3,18}", "Produto", "Preço (F2)", "Qtd (N)", "Total (C)");
Console.WriteLine(cabecalho);
Console.WriteLine(new string('-', cabecalho.Length));

foreach (Produto produto in produtos)
{
    Console.WriteLine(string.Format("{0,-16}{1,14:F2}{2,10:N0}{3,18:C}",
        produto.Nome, produto.Preco, produto.Quantidade, produto.Total));
}

decimal subtotal = produtos.Sum(p => p.Total);
decimal percentualDesconto = 0.10m;
decimal desconto = subtotal * percentualDesconto;
decimal totalFinal = subtotal - desconto;

Console.WriteLine(new string('-', cabecalho.Length));
Console.WriteLine(string.Format("{0,-40}{1,18:C}", "Subtotal:", subtotal));
Console.WriteLine(string.Format("{0,-40}{1,18:C}", $"Desconto ({percentualDesconto:P0}):", desconto));
Console.WriteLine(string.Format("{0,-40}{1,18:C}", "Total final:", totalFinal));
Console.WriteLine();
Console.WriteLine($"Quantidade total de itens: {produtos.Sum(p => p.Quantidade):N0}");
