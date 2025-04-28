
Console.WriteLine("digite o primeiro numero");
decimal primeiroNumero = decimal.Parse(Console.ReadLine()!);


Console.WriteLine("digite o segundo numero");
decimal segundoNumero = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("digite a operação desejada: +, -, *, /");
string operacao = Console.ReadLine()!;

switch (operacao) {
    case "+":
        Console.WriteLine($"Resultado: {primeiroNumero + segundoNumero}");
        break;
    case "-":
        Console.WriteLine($"Resultado: {primeiroNumero - segundoNumero}");
        break;
    case "*":
        Console.WriteLine($"Resultado: {primeiroNumero * segundoNumero}");
        break;
    case "/":
        if (segundoNumero != 0)
            Console.WriteLine($"Resultado: {primeiroNumero / segundoNumero}");
        else
            Console.WriteLine("Divisão por zero não é permitida.");
        break;
    default:
        Console.WriteLine("Operação inválida.");
        break;
} 