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

            // Solicita o terceiro valor
            Console.Write("Digite o terceiro valor: ");
            if (!int.TryParse(Console.ReadLine(), out int valor3))
            {
                Console.WriteLine("Erro: Insira um número inteiro válido para o terceiro valor.");
                return;
            }

            // Verifica se os valores são distintos
            if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3)
            {
                Console.WriteLine("Erro: Os valores não podem ser iguais. Tente novamente.");
                return;
            }

            // Armazena os valores em um array para ordenação
            int[] valores = { valor1, valor2, valor3 };

            // Ordena o array em ordem crescente
            Array.Sort(valores);

            // Exibe os valores em ordem crescente
            Console.WriteLine($"Valores em ordem crescente: {valores[0]}, {valores[1]}, {valores[2]}");
        }
        catch (Exception)
        {
            Console.WriteLine("Erro inesperado. Por favor, insira valores numéricos válidos.");
        }
    }
}
