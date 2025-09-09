// See https://aka.ms/new-console-template for more information
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o ano atual: ");
            if (!int.TryParse(Console.ReadLine(), out int anoAtual) || anoAtual < 0)
            {
                Console.WriteLine("Ano atual inválido. Por favor, insira um número válido.");
                return;
            }

            Console.Write("Digite o ano de nascimento: ");
            if (!int.TryParse(Console.ReadLine(), out int anoNascimento) || anoNascimento < 0 || anoNascimento > anoAtual)
            {
                Console.WriteLine("Ano de nascimento inválido. Por favor, insira um ano válido.");
                return;
            }

            int idade = anoAtual - anoNascimento;

            if (idade < 16)
            {
                Console.WriteLine("Você não pode votar este ano.");
            }
            else if (idade >= 16 && idade < 18 || idade >= 70)
            {
                Console.WriteLine("Seu voto é facultativo este ano.");
            }
            else
            {
                Console.WriteLine("Seu voto é obrigatório este ano.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ocorreu um erro. Por favor, insira valores numéricos válidos.");
        }
    }
}
