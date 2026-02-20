// Pedindo as coordenadas do Ponto A
Console.WriteLine("\nDigite as coordenadas do Ponto A:");
Console.Write("X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Z1: ");
double z1 = double.Parse(Console.ReadLine());

// Pedindo as coordenadas do Ponto B
Console.WriteLine("\nDigite as coordenadas do Ponto B:");
Console.Write("X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Z2: ");
double z2 = double.Parse(Console.ReadLine());



// Raiz Quadrada de ((x2-x1)² + (y2-y1)² + (z2-z1)²)

double deltaX = x2 - x1;
double deltaY = y2 - y1;
double deltaZ = z2 - z1;


//Utilizamos o mathpow para elevar o numero a potencia

double distancia = Math.Sqrt(
    Math.Pow(deltaX, 2) +
    Math.Pow(deltaY, 2) +
    Math.Pow(deltaZ, 2)
);

// --- RESULTADO --- 
Console.WriteLine("\n-------------------------------------------");
Console.WriteLine($"A distância entre os pontos é: {distancia}");
Console.WriteLine("-------------------------------------------");


Console.ReadLine();