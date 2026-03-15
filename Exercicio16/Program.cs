// 16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.Write("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine($"O número {numero} é par.");
}

else
{
    Console.WriteLine("---------------------------");
    Console.WriteLine($"O número {numero} é ímpar.");
}