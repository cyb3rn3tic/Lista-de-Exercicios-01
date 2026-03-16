// 22. Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

Console.Write("Digite um número inteiro para calcular a sequência de Fibonacci: ");
int numero = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;

Console.WriteLine($"-----------------------------------------------------------------");
Console.Write($"Sequência de Fibonacci para {numero} é: ");
while (a <= numero)
{
    Console.Write($"{a} ");
    int temp = a;
    a = b;
    b = temp + b;
}