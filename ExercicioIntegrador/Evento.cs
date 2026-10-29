namespace ExercicioIntegrador;

public class Evento
{
    public string Nome { get; }
    public DateTime Data { get; }
    public decimal ValorIngresso { get; }
    public string Categoria { get; } // "VIP" ou "COMUM"

    public Evento(string nome, DateTime data, decimal valorIngresso, string categoria)
    {
        Nome = nome;
        Data = data;
        ValorIngresso = valorIngresso;
        Categoria = categoria;
    }

    // Valida o texto digitado usando ToUpper e Contains. Retorna null se for inválido.
    public static string? ValidarCategoria(string entrada)
    {
        string texto = entrada.Trim().ToUpper();

        if (texto.Contains("VIP"))
            return "VIP";
        if (texto.Contains("COMUM"))
            return "COMUM";

        return null;
    }

    public int DiasRestantes()
    {
        return (Data.Date - DateTime.Today).Days;
    }

    // Desconto por compra antecipada: 15% com 30 dias ou mais, 5% com 7 dias ou mais
    public decimal PercentualDesconto()
    {
        int dias = DiasRestantes();

        if (dias >= 30)
            return 0.15m;
        if (dias >= 7)
            return 0.05m;

        return 0m;
    }

    public decimal ValorFinal()
    {
        return Math.Round(ValorIngresso * (1 - PercentualDesconto()), 2);
    }

    public void ExibirIngresso()
    {
        string linha = new string('=', 46);

        Console.WriteLine(linha);
        Console.WriteLine(string.Format("{0,-22}{1,24}", "*** INGRESSO ***", $"Categoria: {Categoria}"));
        Console.WriteLine(linha);
        Console.WriteLine(string.Format("{0,-22}{1,24}", "Evento:", Nome));
        Console.WriteLine(string.Format("{0,-22}{1,24:dd/MM/yyyy}", "Data:", Data));
        Console.WriteLine(string.Format("{0,-22}{1,24}", "Dias restantes:", DiasRestantes()));
        Console.WriteLine(string.Format("{0,-22}{1,24:C}", "Valor do ingresso:", ValorIngresso));
        Console.WriteLine(string.Format("{0,-22}{1,24:P0}", "Desconto antecipado:", PercentualDesconto()));
        Console.WriteLine(string.Format("{0,-22}{1,24:C}", "Valor a pagar:", ValorFinal()));
        Console.WriteLine(linha);
    }
}
