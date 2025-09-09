// See https://aka.ms/new-console-template for more information

int numero;

Console.WriteLine("Olá, digite um número e direi se é maior que 10.");
   numero = int.Parse(Console.ReadLine());
if (numero >10)
{
    Console.WriteLine("O Valor digitado é maior do que 10");

}
else
{
    Console.WriteLine("O valor digitado não é maior do que 10");
}
Console.ReadLine();
