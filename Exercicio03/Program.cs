/* 3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. 
O programa deve solicitar ao usuário:
● A quilometragem inicial do veículo no início da viagem.
● A quilometragem final ao término da viagem.
● A quantidade de combustível consumida durante a viagem (em litros). */

Console.Write("Digite a Km inicial do veículo no início da viagem: ");
double KmInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a Km final ao término da viagem: ");
double KmFinal = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de combustível consumida durante a viagem (em litros): ");
double combustivelConsumido = Convert.ToDouble(Console.ReadLine());

double KmPercorridos = KmFinal - KmInicial;
double consumoPorKm = combustivelConsumido / KmPercorridos;
double KmPorLitro = KmPercorridos / combustivelConsumido;

Console.WriteLine($"--------------------------------------------------");
Console.WriteLine($"O consumo de combustível por Km percorrido é: {consumoPorKm:F2} L/km");
Console.WriteLine("Ou");
Console.WriteLine($"A autonomia do veículo por Km percorrido é: {KmPorLitro:F2} km/L");