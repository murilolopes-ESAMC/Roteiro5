using Exercicio2A;

Console.WriteLine("--- Exercício 2 a): Operações com String ---");
Console.WriteLine("Digite uma frase com espaços no início e no fim e palavras separadas por vírgulas.");
Console.WriteLine("Exemplo: \"   maçã,banana,uva,laranja   \"");
Console.Write("Frase: ");
string frase = Console.ReadLine() ?? "";

ProcessadorFrase processador = new ProcessadorFrase(frase);

Console.WriteLine();
Console.WriteLine($"Original:   [{processador.FraseOriginal}]");
Console.WriteLine($"Com Trim(): [{processador.FraseLimpa}]");

Console.WriteLine();
Console.WriteLine("Partes com Split(','):");
string[] partes = processador.DividirPartes();
for (int i = 0; i < partes.Length; i++)
{
    Console.WriteLine($"  {i + 1}. {partes[i].Trim()}");
}

Console.WriteLine();
Console.Write("Palavra que deseja substituir: ");
string antiga = Console.ReadLine() ?? "";
Console.Write("Nova palavra: ");
string nova = Console.ReadLine() ?? "";
if (antiga.Length > 0)
{
    Console.WriteLine($"Com Replace(): {processador.Substituir(antiga, nova)}");
}
else
{
    Console.WriteLine("Nenhuma palavra informada para substituir.");
}

Console.WriteLine();
Console.Write("Verificar se a frase começa com: ");
string inicio = Console.ReadLine() ?? "";
Console.WriteLine($"StartsWith(\"{inicio}\"): {(processador.ComecaCom(inicio) ? "Sim" : "Não")}");

Console.Write("Verificar se a frase termina com: ");
string fim = Console.ReadLine() ?? "";
Console.WriteLine($"EndsWith(\"{fim}\"): {(processador.TerminaCom(fim) ? "Sim" : "Não")}");
