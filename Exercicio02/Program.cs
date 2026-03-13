// 2. Crie um programa para calcular o volume de um Cilindro

Console.WriteLine("Digite a unidade de medida: ");
Console.WriteLine("1- cm: ");
Console.WriteLine("2- m: ");
int opcao = Convert.ToInt32(Console.ReadLine());

while (opcao != 1 && opcao != 2)
{
    Console.Clear();
    Console.WriteLine("Opção inválida. Por favor, escolha 1 para cm ou 2 para m.");
    opcao = Convert.ToInt32(Console.ReadLine());
}    
    if (Convert.ToInt32(opcao) == 1)
    {
        Console.Write("Digite o raio da cilindro em cm: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do cilindro em cm: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine($"--------------------------------------------------");
        Console.WriteLine($"O volume do cilindro é: {volume:F2} cm³");
        Console.WriteLine($"O volume do cilindro em litros é: {volume/ 1000:F2}  L");
    }

    else if (Convert.ToInt32(opcao) == 2)
    {
        Console.Write("Digite o raio da cilindro em m: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do cilindro em m: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine($"--------------------------------------------------");
        Console.WriteLine($"O volume do cilindro é: {volume:F2} m³");
        Console.WriteLine($"O volume do cilindro em litros é: {volume * 1000:F2} L");
    }