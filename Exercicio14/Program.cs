// 14. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

Console.Write("Digite o valor de A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de C: ");
int C = Convert.ToInt32(Console.ReadLine());

bool valoresDiferentes = A == B || A == C || B == C;

if (valoresDiferentes)
{
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("Os valores devem ser diferentes. Por favor, tente novamente.");
}

else if (A > B && A > C)
{
    if (B > C)
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Ordem decrescente: {A}, {B}, {C}");
    }

    else
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Ordem decrescente: {A}, {C}, {B}");
    }
}

else if (B > A && B > C)
{
    if (A > C)
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Ordem decrescente: {B}, {A}, {C}");
    }

    else
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Ordem decrescente: {B}, {C}, {A}");
    }
}

else
{
    if (A > B)
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Ordem decrescente: {C}, {A}, {B}");
    }
    
    else
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Ordem decrescente: {C}, {B}, {A}");
    }
}