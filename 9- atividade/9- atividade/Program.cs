// See https://aka.ms/new-console-template for more information
{
    Console.WriteLine("Digite o número de maçãs compradas: ");

    // Verifica se a entrada é um número inteiro válido
    if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade < 0)
    {
        Console.WriteLine("Por favor, digite um número inteiro não negativo.");
        return;
    }

    double precoPorMaca = quantidade < 12 ? 1.30 : 1.00;
    double custoTotal = quantidade * precoPorMaca;

    Console.WriteLine($"O custo total da compra é: R${custoTotal:F2}");
}
