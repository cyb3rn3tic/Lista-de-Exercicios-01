// 8. Crie um programa para verificar se um número é primo.

Console.Write("Digite um número inteiro positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());

bool ehPrimo = true;

if (numero <= 1)
{
    ehPrimo = false;
}

else
{
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            ehPrimo = false;
            break;
        }
    }
}

if (ehPrimo)
{
    Console.WriteLine($"{numero} é um número primo.");
}

else
{
    Console.WriteLine($"{numero} não é um número primo.");
}
