// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

Console.Write("Digite o valor de A: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de B: ");
double B = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de C: ");
double C = Convert.ToDouble(Console.ReadLine());

double somaAB = A + B;

if (somaAB < C)
{
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine($"A soma de A + B ({somaAB}) é menor que C ({C}).");
}

else if(somaAB == C)
{
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"A soma de A + B ({somaAB}) é igual a C ({C}).");
}

else
{
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine($"A soma de A + B ({somaAB}) é maior que C ({C}).");
}
