namespace Exercicio2B;

public class Cpf
{
    public string Original { get; }
    public string Numeros { get; }

    public Cpf(string entrada)
    {
        Original = entrada;
        // Limpa a string: remove espaços das pontas, pontos, traços e espaços internos
        Numeros = entrada.Trim().Replace(".", "").Replace("-", "").Replace(" ", "");
    }

    public bool TemOnzeDigitos()
    {
        return Numeros.Length == 11 && Numeros.All(char.IsDigit);
    }

    public bool ComecaComDigitoValido()
    {
        string[] digitos = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        foreach (string digito in digitos)
        {
            if (Numeros.StartsWith(digito))
            {
                return true;
            }
        }

        return false;
    }

    // Formato 000.000.000-00
    public string Formatar()
    {
        return $"{Numeros.Substring(0, 3)}.{Numeros.Substring(3, 3)}.{Numeros.Substring(6, 3)}-{Numeros.Substring(9, 2)}";
    }
}
