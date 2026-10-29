using System.Globalization;

namespace Exercicio4;

public class Compromisso
{
    public string NomeUsuario { get; }
    public DateTime DataHora { get; }

    public Compromisso(string nomeUsuario, DateTime dataHora)
    {
        NomeUsuario = nomeUsuario;
        DataHora = dataHora;
    }

    public int DiasRestantes()
    {
        return (DataHora.Date - DateTime.Today).Days;
    }

    public string DiaDaSemana()
    {
        return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DataHora.DayOfWeek);
    }

    public string GerarMensagem()
    {
        // "no sábado" / "no domingo", mas "na segunda-feira", "na terça-feira"...
        bool fimDeSemana = DataHora.DayOfWeek == DayOfWeek.Saturday || DataHora.DayOfWeek == DayOfWeek.Sunday;
        string artigo = fimDeSemana ? "no" : "na";

        int dias = DiasRestantes();
        string quando;
        if (dias > 1)
            quando = $"em {dias} dias";
        else if (dias == 1)
            quando = "amanhã";
        else if (dias == 0)
            quando = "hoje";
        else
            quando = $"há {-dias} dias (já passou)";

        return string.Format(
            "Olá, {0}!\nSeu compromisso será {1}, {2} {3}.\nData marcada: {4:dd/MM/yyyy} às {4:HH:mm}",
            NomeUsuario, quando, artigo, DiaDaSemana(), DataHora);
    }
}
