namespace Exercicio1A;

public class NumeroDecimal
{
    public double Valor { get; }

    public NumeroDecimal(double valor)
    {
        Valor = valor;
    }

    // Obs.: Math.Round usa por padrão o "arredondamento bancário" (para o par mais próximo):
    // 2,5 -> 2 e 3,5 -> 4.
    public void ExibirArredondamentos()
    {
        Console.WriteLine($"Número original: {Valor}");
        Console.WriteLine($"  Math.Round    (padrão):     {Math.Round(Valor)}");
        Console.WriteLine($"  Math.Floor    (para baixo): {Math.Floor(Valor)}");
        Console.WriteLine($"  Math.Ceiling  (para cima):  {Math.Ceiling(Valor)}");
        Console.WriteLine($"  Math.Truncate (truncado):   {Math.Truncate(Valor)}");
        Console.WriteLine();
    }
}
