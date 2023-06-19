    Calcular c = new Calcular();
    double n1 = Convert.ToDouble(Console.ReadLine());
    double n2 = Convert.ToDouble(Console.ReadLine());
    double retornoSoma = c.Soma(n1, n2);
    Console.WriteLine(retornoSoma);

    Calcular d = new Calcular();
    double n3 = Convert.ToDouble(Console.ReadLine());
    double n4 = Convert.ToDouble(Console.ReadLine());
    double retornoSubtracao = d.Subtracao(n1, n2);
    Console.WriteLine(retornoSubtracao);

    Calcular e = new Calcular();
    double n5 = Convert.ToDouble(Console.ReadLine());
    double n6 = Convert.ToDouble(Console.ReadLine());
    double retornoMultiplicacao = e.Multiplicacao(n1, n2);
    Console.WriteLine(retornoMultiplicacao);

    Calcular f = new Calcular();
    double n7 = Convert.ToDouble(Console.ReadLine());
    double n8 = Convert.ToDouble(Console.ReadLine());
    double retornoDivisao = f.divisao(n1, n2);
    Console.WriteLine(retornoDivisao);

    