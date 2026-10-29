using System.Globalization;
using Exercicio4;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício 4: Datas e calendários ---");

Console.Write("Seu nome: ");
string nome = Console.ReadLine() ?? "";

DateTime dataHora;
while (true)
{
    Console.Write("Data e hora do compromisso (dd/MM/yyyy HH:mm): ");
    string entrada = Console.ReadLine() ?? "";

    if (DateTime.TryParseExact(entrada, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture,
            DateTimeStyles.None, out dataHora))
    {
        break;
    }

    Console.WriteLine("Formato inválido. Exemplo: 12/04/2025 15:00");
}

Compromisso compromisso = new Compromisso(nome, dataHora);

Console.WriteLine();
Console.WriteLine(compromisso.GerarMensagem());
