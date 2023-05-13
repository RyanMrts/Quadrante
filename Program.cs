Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("~~ Quadrante ~~");
Console.ResetColor();
Console.WriteLine("Digite as coordenadas desejadas");
Console.Write("Coordenada X: ");
double coordenadaX = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordenada Y: ");
double coordenadaY = Convert.ToDouble(Console.ReadLine());

    if (coordenadaX > 0 && coordenadaY > 0)
    {
        Console.WriteLine($" O ponto ({coordenadaX}, {coordenadaY}) fica no quadrante 1 (I).");
    }
    else if (coordenadaX < 0 && coordenadaY > 0)
    {
        Console.WriteLine($" O ponto ({coordenadaX}, {coordenadaY}) fica no quadrante 2 (II).");
    }
    else if (coordenadaX < 0 && coordenadaY < 0)
    {
        Console.WriteLine($" O ponto ({coordenadaX}, {coordenadaY}) fica no quadrante 3 (III).");
    }
    else if (coordenadaX > 0 && coordenadaY < 0) 
    {
        Console.WriteLine($" O ponto ({coordenadaX}, {coordenadaY}) fica no quadrante 4 (IV).");
    }

    else
    {
        Console.Write("O ponto (0, 0) fica na origem.");
    }