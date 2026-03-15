// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. 
// Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

Console.Write("Digite a largura do terreno em metros: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o comprimento do terreno em metros: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

double area = largura * comprimento;

Console.WriteLine($"--------------------------------------------------");
Console.WriteLine($"A área do terreno é: {area} metros quadrados.");