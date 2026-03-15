//12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
//impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

Console.Write("Digite o salário do funcionário: R$");
double salarioInicial = Convert.ToDouble(Console.ReadLine());


//double aumento = salarioInicial * 0.15; Da pra fazer assim também, mas é mais simples multiplicar direto por 1.15
//double salarioComAumento = salarioInicial + aumento; 

double salarioComAumento = salarioInicial * 1.15;

//double imposto = salarioComAumento * 0.08; Da pra fazer assim também, mas é mais simples multiplicar direto por 0.92 (100% - 8% = 92% = 0.92)
//double salarioFinal = salarioComAumento - imposto;

double salarioFinal = salarioComAumento * 0.92;

Console.WriteLine("----------------------------------------------");
Console.WriteLine($"Salário inicial: R${salarioInicial:F2}");
Console.WriteLine($"Salário com aumento de 15%: R${salarioComAumento:F2}");
Console.WriteLine($"Salário final após desconto de 8% de impostos: R${salarioFinal:F2}");