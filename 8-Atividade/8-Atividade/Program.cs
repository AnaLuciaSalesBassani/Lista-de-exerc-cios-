// See https://aka.ms/new-console-template for more information
int numero;
Console.WriteLine("Digite um numero (que não seja zero)");
numero = int.Parse(Console.ReadLine());
if (numero == 0)
{
    Console.WriteLine("Número inválido.");
}
if (numero > 0)
{
    Console.WriteLine("Esse número é positivo");
}
if (numero < 0)
{
    Console.WriteLine("O número é positivo");
}
Console.ReadLine();