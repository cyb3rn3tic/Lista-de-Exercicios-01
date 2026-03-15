/* 
10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
de pães e de broas, e depois calcular os dados solicitados. 
*/

Console.Write("Digite a quantidade de pães vendidos: ");
int quantidadePaes = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de broas vendidas: ");
int quantidadeBroas = Convert.ToInt32(Console.ReadLine());

double precoPao = 0.12;
double precoBroa = 1.5;

double totalArrecadado = (quantidadePaes * precoPao) + (quantidadeBroas * precoBroa);
double valorPoupanca = totalArrecadado * 0.10;

Console.WriteLine("----------------------------------------------");
Console.WriteLine($"Total arrecadado: R${totalArrecadado:F2}");
Console.WriteLine($"Valor a guardar na poupança: R${valorPoupanca:F2}");

