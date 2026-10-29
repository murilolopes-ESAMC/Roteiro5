using System.Globalization;
using ExercicioIntegrador;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine("--- Exercício Integrador: Cadastro de evento ---");

string nome;
do
{
    Console.Write("Nome do evento: ");
    nome = (Console.ReadLine() ?? "").Trim();
} while (nome.Length == 0);

DateTime data;
while (true)
{
    Console.Write("Data do evento (dd/MM/yyyy): ");
    string entrada = Console.ReadLine() ?? "";

    if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data)
        && data.Date >= DateTime.Today)
    {
        break;
    }

    Console.WriteLine("Data inválida. Informe uma data de hoje em diante no formato dd/MM/yyyy.");
}

decimal valor;
while (true)
{
    Console.Write("Valor do ingresso (R$): ");
    if (decimal.TryParse(Console.ReadLine(), out valor) && valor > 0)
    {
        break;
    }

    Console.WriteLine("Valor inválido. Digite um número maior que zero.");
}

string? categoria;
while (true)
{
    Console.Write("Categoria (VIP/Comum): ");
    categoria = Evento.ValidarCategoria(Console.ReadLine() ?? "");
    if (categoria != null)
    {
        break;
    }

    Console.WriteLine("Categoria inválida. Digite VIP ou Comum.");
}

Evento evento = new Evento(nome, data, valor, categoria);

Console.WriteLine();
evento.ExibirIngresso();
