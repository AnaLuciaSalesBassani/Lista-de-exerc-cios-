// See https://aka.ms/new-console-template for more information
namespace MediaBimestral
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados com validação
            Console.WriteLine("=== Calculadora de Média Bimestral ===");

            double nota1 = LerNota("1ª avaliação");
            double nota2 = LerNota("2ª avaliação");

            // Cálculo da média aritmética
            double media = (nota1 + nota2) / 2.0;

            // Saída de resultados
            Console.WriteLine("\n=== Resultado ===");
            Console.WriteLine($"Média: {media:F2}");

            // Verificação de aprovação
            if (media >= 6.0)
            {
                Console.WriteLine("Situação: APROVADO");
            }
            else
            {
                Console.WriteLine("Situação: REPROVADO");
            }

            // Pausa para visualizar o resultado
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        // Função para ler e validar a nota
        static double LerNota(string avaliacao)
        {
            double nota;
            while (true)
            {
                Console.Write($"Digite a nota da {avaliacao} (0-10): ");
                if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                {
                    return nota;
                }
                Console.WriteLine("Erro: Digite um número válido entre 0 e 10.");
            }
        }
    }
}