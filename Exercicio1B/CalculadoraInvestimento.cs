namespace Exercicio1B;

public class CalculadoraInvestimento
{
    public double CapitalInicial { get; }
    public double TaxaMensal { get; } // em porcentagem, ex.: 1,5 = 1,5% ao mês
    public int Meses { get; }

    public CalculadoraInvestimento(double capitalInicial, double taxaMensal, int meses)
    {
        CapitalInicial = capitalInicial;
        TaxaMensal = taxaMensal;
        Meses = meses;
    }

    // Juros compostos: M = C * (1 + i)^n
    public double CalcularMontante()
    {
        return CapitalInicial * Math.Pow(1 + TaxaMensal / 100, Meses);
    }

    public double CalcularLucro()
    {
        return Math.Round(CalcularMontante() - CapitalInicial, 2);
    }

    public bool SuperaMeta(double meta)
    {
        return CalcularLucro() > meta;
    }
}
