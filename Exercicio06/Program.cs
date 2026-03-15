// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

    Console.WriteLine("-------------------------------");
    Console.WriteLine("Calculadora de media harmonica");
    Console.WriteLine("-------------------------------");

    int QuantidadeDeNotas;
    double mediaHarmonica;
    double notaDigitada;
    double somatorioMediaHarmonica = 0;

    Console.Write("Digite quantas notas vc quer calcular: ");
    QuantidadeDeNotas = Convert.ToInt32(Console.ReadLine());

    double[] notasAlunos = new double[QuantidadeDeNotas];

    for (int cont = 0; cont < QuantidadeDeNotas; cont++)
    {   
        Console.Clear();

        Console.Write($"Digite a nota {cont + 1} do aluno: ");
        notaDigitada = Convert.ToDouble(Console.ReadLine());

        if (notaDigitada == 0)
        {   
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Nota não pode ser 0 na média harmônica!");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
            cont--;
            
            continue;
        }

        notasAlunos[cont] = notaDigitada;
    }

    for(int cont = 0; cont < QuantidadeDeNotas; cont++)
    {
        somatorioMediaHarmonica += 1 / notasAlunos[cont];
    }
    
    mediaHarmonica = QuantidadeDeNotas / somatorioMediaHarmonica;

    Console.WriteLine("----------------------------------------------");
    Console.WriteLine($"A média harmônica é: {mediaHarmonica:F2}");