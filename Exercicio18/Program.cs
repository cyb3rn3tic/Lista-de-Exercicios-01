// 18. Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

Console.WriteLine("Números ímpares entre 100 e 200:");

for (int i = 101; i < 200; i += 2) // como é um intervalo que da pra saber quais os impares, podemos iniciar a variável com o primeiro número ímpar e ir somando 2 para obter os próximos ímpares
{
    Console.Write($"{i}, ");
}