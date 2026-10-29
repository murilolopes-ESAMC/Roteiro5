using System.Globalization;
using Exercicio1B;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício 1 b): Calculadora de investimento ---");

double capital = LerDouble("Capital inicial (R$): ");
double taxa = LerDouble("Taxa de juros mensal (%): ");
int meses = (int)LerDouble("Número de meses: ");
double meta = LerDouble("Meta de lucro (R$): ");

CalculadoraInvestimento calculadora = new CalculadoraInvestimento(capital, taxa, meses);
double lucro = calculadora.CalcularLucro();

Console.WriteLine();
Console.WriteLine($"Montante final: {calculadora.CalcularMontante():C}");
Console.WriteLine($"Lucro (arredondado): {lucro:C}");

if (calculadora.SuperaMeta(meta))
{
    Console.WriteLine($"Parabéns! O lucro supera a meta de {meta:C}.");
}
else
{
    Console.WriteLine($"O lucro NÃO supera a meta de {meta:C}.");
}

static double LerDouble(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        if (double.TryParse(Console.ReadLine(), out double valor) && valor >= 0)
        {
            return valor;
        }
        Console.WriteLine("Valor inválido. Digite um número maior ou igual a zero.");
    }
}
