using Exercicio2B;

Console.WriteLine("--- Exercício 2 b): Formatação de CPF ---");
Console.Write("Digite um CPF (pode ter pontos, traços e espaços): ");
string entrada = Console.ReadLine() ?? "";

Cpf cpf = new Cpf(entrada);

Console.WriteLine($"CPF limpo: {cpf.Numeros}");

if (!cpf.ComecaComDigitoValido())
{
    Console.WriteLine("CPF inválido: deve começar com um dígito (0 a 9).");
}
else if (!cpf.TemOnzeDigitos())
{
    Console.WriteLine($"CPF inválido: deve conter exatamente 11 dígitos (informado: {cpf.Numeros.Length} caracteres).");
}
else
{
    Console.WriteLine($"CPF formatado: {cpf.Formatar()}");
}
