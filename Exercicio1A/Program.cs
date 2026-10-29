using System.Globalization;
using Exercicio1A;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício 1 a): Classe Math - arredondamentos ---");

NumeroDecimal[] numeros = new NumeroDecimal[5];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = new NumeroDecimal(LerDouble($"Digite o {i + 1}º número decimal: "));
}

Console.WriteLine();

foreach (NumeroDecimal numero in numeros)
{
    numero.ExibirArredondamentos();
}

static double LerDouble(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        if (double.TryParse(Console.ReadLine(), out double valor))
        {
            return valor;
        }
        Console.WriteLine("Valor inválido. Use vírgula para as casas decimais (ex.: 3,75).");
    }
}
