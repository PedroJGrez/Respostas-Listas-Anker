using System;

class CorpoCeleste
{
    private double massa;
    private double densidade;
    private double posicaoX;
    private double posicaoY;

    public CorpoCeleste(double massa, double densidade, double posicaoX, double posicaoY)
    {
        this.massa = massa;
        this.densidade = densidade;
        this.posicaoX = posicaoX;
        this.posicaoY = posicaoY;
    }

    public double GetMassa()
    {
        return massa;
    }

    public double GetDensidade()
    {
        return densidade;
    }

    public double GetPosicaoX()
    {
        return posicaoX;
    }

    public double GetPosicaoY()
    {
        return posicaoY;
    }

    // Raio calculado a partir da massa e da densidade
    // Fórmula: Volume = Massa / Densidade, Volume = (4/3) * PI * r³
    public double GetRaio()
    {
        double volume = massa / densidade;
        double raio = Math.Cbrt((3 * volume) / (4 * Math.PI));
        return raio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CorpoCeleste[] corpos = new CorpoCeleste[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Corpo Celeste " + (i + 1));

            Console.Write("Massa: ");
            double massa = double.Parse(Console.ReadLine());

            Console.Write("Densidade: ");
            double densidade = double.Parse(Console.ReadLine());

            Console.Write("Posicao X: ");
            double posX = double.Parse(Console.ReadLine());

            Console.Write("Posicao Y: ");
            double posY = double.Parse(Console.ReadLine());

            corpos[i] = new CorpoCeleste(massa, densidade, posX, posY);
            Console.WriteLine();
        }

        // Corpo de maior massa
        CorpoCeleste maiorMassa = corpos[0];
        for (int i = 1; i < 10; i++)
        {
            if (corpos[i].GetMassa() > maiorMassa.GetMassa())
            {
                maiorMassa = corpos[i];
            }
        }

        // Corpo de maior raio
        CorpoCeleste maiorRaio = corpos[0];
        for (int i = 1; i < 10; i++)
        {
            if (corpos[i].GetRaio() > maiorRaio.GetRaio())
            {
                maiorRaio = corpos[i];
            }
        }

        // Dois corpos mais distantes entre si (considerando o eixo X)
        int indiceA = 0;
        int indiceB = 1;
        double maiorDistancia = Math.Abs(corpos[0].GetPosicaoX() - corpos[1].GetPosicaoX());

        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                double distancia = Math.Abs(corpos[i].GetPosicaoX() - corpos[j].GetPosicaoX());
                if (distancia > maiorDistancia)
                {
                    maiorDistancia = distancia;
                    indiceA = i;
                    indiceB = j;
                }
            }
        }

        Console.WriteLine("=== RESULTADOS ===");

        Console.WriteLine("\nCorpo de maior massa:");
        Console.WriteLine("  Massa: " + maiorMassa.GetMassa());
        Console.WriteLine("  Raio: " + maiorMassa.GetRaio());
        Console.WriteLine("  Posicao X: " + maiorMassa.GetPosicaoX());

        Console.WriteLine("\nCorpo de maior raio:");
        Console.WriteLine("  Raio: " + maiorRaio.GetRaio());
        Console.WriteLine("  Massa: " + maiorRaio.GetMassa());
        Console.WriteLine("  Posicao X: " + maiorRaio.GetPosicaoX());

        Console.WriteLine("\nDois corpos mais distantes no eixo X:");
        Console.WriteLine("  Corpo " + (indiceA + 1) + " (X = " + corpos[indiceA].GetPosicaoX() + ")");
        Console.WriteLine("  Corpo " + (indiceB + 1) + " (X = " + corpos[indiceB].GetPosicaoX() + ")");
        Console.WriteLine("  Distancia entre eles: " + maiorDistancia);
    }
}
