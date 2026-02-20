using System;

class Ponto
{
    private double x;
    private double y;

    // Construtor sem parâmetros
    public Ponto()
    {
        x = 0;
        y = 0;
    }

    // Construtor com coordenadas X e Y
    public Ponto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Construtor que recebe outro ponto
    public Ponto(Ponto outroPonto)
    {
        this.x = outroPonto.x;
        this.y = outroPonto.y;
    }

    public double GetX()
    {
        return x;
    }

    public double GetY()
    {
        return y;
    }

    public void ExibirPonto()
    {
        Console.WriteLine("Ponto: (" + x + ", " + y + ")");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ponto p1 = new Ponto();
        p1.ExibirPonto();

        Ponto p2 = new Ponto(3, 5);
        p2.ExibirPonto();

        Ponto p3 = new Ponto(p2);
        p3.ExibirPonto();
    }
}

