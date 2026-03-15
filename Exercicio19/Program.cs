// 19. Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
// encontram no conjunto dos números de 1 até 500.

int soma = 0;

for (int cont = 1; cont <= 500; cont++)
{
    if (cont % 2 != 0 && cont % 3 == 0)
    {
        soma += cont;
    }
}

Console.WriteLine($"A soma dos números ímpares que são múltiplos de 3 entre 1 e 500 é: {soma}");