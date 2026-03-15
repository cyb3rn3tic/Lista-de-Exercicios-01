/*
 11. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
*/

Console.Write("Digite o nome da pessoa: ");
string? nome = Console.ReadLine(); // Não precisa fazer Convert.ToString pq o default do Console.ReadLine() já é string.

Console.Write("Digite a idade da pessoa: ");
int idade = Convert.ToInt32(Console.ReadLine());

int diasDeVida = idade * 365;

Console.WriteLine("----------------------------------------------");
Console.WriteLine($"{nome}, VOCÊ JÁ VIVEU {diasDeVida} DIAS.");