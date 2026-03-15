// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

Console.Write("Digite a nota da primeira prova: ");
double notaProva1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da primeira prova: ");
double pesoProva1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
double notaProva2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da segunda prova: ");
double pesoProva2 = Convert.ToDouble(Console.ReadLine());

double mediaPonderada = ((notaProva1 * pesoProva1) + (notaProva2 * pesoProva2)) / (pesoProva1 + pesoProva2);

Console.WriteLine($"--------------------------------------------------");
Console.WriteLine($"A média ponderada das provas é: {mediaPonderada}");