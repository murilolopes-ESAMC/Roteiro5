namespace Exercicio2A;

public class ProcessadorFrase
{
    public string FraseOriginal { get; }
    public string FraseLimpa { get; }

    public ProcessadorFrase(string frase)
    {
        FraseOriginal = frase;
        FraseLimpa = frase.Trim(); // Remove os espaços do início e do fim
    }

    public string[] DividirPartes()
    {
        return FraseLimpa.Split(',');
    }

    public string Substituir(string palavraAntiga, string palavraNova)
    {
        return FraseLimpa.Replace(palavraAntiga, palavraNova);
    }

    public bool ComecaCom(string palavra)
    {
        return FraseLimpa.StartsWith(palavra);
    }

    public bool TerminaCom(string palavra)
    {
        return FraseLimpa.EndsWith(palavra);
    }
}
