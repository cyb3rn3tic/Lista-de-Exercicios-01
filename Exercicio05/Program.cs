// 5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas.
// A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

Console.Write("Digite o salário base do vendedor: R$");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o total de vendas do vendedor: R$");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o percentual de comissão: %");
double percentualComissao = Convert.ToDouble(Console.ReadLine());

double comissao = percentualComissao / 100 * totalVendas; // o compilador "disse" que não necessita colocar o parenteses
double salarioTotal = salarioBase + comissao;

Console.WriteLine($"--------------------------------------------------");
Console.WriteLine($"O salário total do vendedor é: R${salarioTotal:F2}");
