// 17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, 
// caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
// variável C e mostrar seu conteúdo na tela.

int A, B, C;

Console.Write("Digite um valor inteiro para A: ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite um valor inteiro para B: ");
B = Convert.ToInt32(Console.ReadLine());

if (A == B)
{
    C = A + B;
    Console.WriteLine("-----------------------");
    Console.WriteLine($"O valor de C é: {C}"); 
    Console.WriteLine($"Resultado de {A} + {B}");
}

else
{
    C = A * B;
    Console.WriteLine("-----------------------");
    Console.WriteLine($"O valor de C é: {C}"); 
    Console.WriteLine($"Resultado de {A} x {B}");
}

