/*
    21. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
    resultado.
    a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    b. Pesquise sobre “fatorial”


Console.Write("Digite um valor inteiro para calcular o fatorial: ");
int A = Convert.ToInt32(Console.ReadLine());

int fatorial = 1;

Console.Write($"{A}! = ");

for (int cont = A; cont > 0; cont--)
{
    fatorial *= cont;
    Console.Write(cont);
    if (cont > 1)
    {
        Console.Write(" X ");
    }
}
Console.WriteLine($" = {fatorial}");
*/

// Outra forma de resolver o exercício:

Console.Write("Digite um valor inteiro para calcular o fatorial: ");
int A = Convert.ToInt32(Console.ReadLine());

int fatorial = A;
int[] arrayDeA =  new int[A]; 

Console.Write($"{A}! = {A}");
for(int i = A-1; i > 0; i--)
{
    arrayDeA[i] = i;
    Console.Write($" x {i}");
    fatorial *= arrayDeA[i];
}
Console.WriteLine($" = {fatorial}");