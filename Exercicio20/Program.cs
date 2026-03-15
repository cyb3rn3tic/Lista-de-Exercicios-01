/* 
    20. Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
    tabuada na forma:
    ● 0 x N = 0,
    ● 1 x N = 1N,
    ● 2 x N = 2N,
    .
    .
    .
    ● 10 x N = 10N.
*/

Console.Write("Digite um valor inteiro para N no intervalo de 1 a 10: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("------------------");
Console.WriteLine($"Tabuada de {N}");
Console.WriteLine("------------------");

for (int i = 0; i <= 10; i++)
{
    int resultado = i * N;
    Console.WriteLine($"{i} x {N} = {resultado}{N}"); // no caso se fosse pra mostrar literalmente a letra N, teria feito "...{resultado}N"
}
