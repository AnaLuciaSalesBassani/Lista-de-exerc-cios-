// See https://aka.ms/new-console-template for more information
{
    static void Main(string[] args)
    {
        try
        {
            // Solicita o primeiro valor
            Console.Write("Digite o primeiro valor: ");
            if (!int.TryParse(Console.ReadLine(), out int valor1))
            {
                Console.WriteLine("Erro: Insira um número inteiro válido para o primeiro valor.");
                return;
            }

            // Solicita o segundo valor
            Console.Write("Digite o segundo valor: ");
            if (!int.TryParse(Console.ReadLine(), out int valor2))
            {
                Console.WriteLine("Erro: Insira um número inteiro válido para o segundo valor.");
                return;
            }

            // Verifica se os valores são iguais
            if (valor1 == valor2)
            {
                Console.WriteLine("Erro: Os valores não podem ser iguais. Tente novamente.");
                return;
            }

            // Determina e exibe o maior valor
            int maior = valor1 > valor2 ? valor1 : valor2;
            Console.WriteLine($"O maior valor é: {maior}");
        }
        catch (Exception)
        {
            Console.WriteLine("Erro inesperado. Por favor, insira valores numéricos válidos.");
        }
    }
}