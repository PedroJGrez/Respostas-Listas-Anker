using System;

class Retangulo
{
    private double base_;
    private double altura;

    public double Base
    {
        get { return base_; }
        set { base_ = value; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public double Area
    {
        get { return base_ * altura; }
    }

    public void ExibirDados()
    {
        Console.WriteLine("Base: " + base_);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Area: " + Area);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo();

        Console.Write("Informe a base: ");
        r.Base = double.Parse(Console.ReadLine());

        Console.Write("Informe a altura: ");
        r.Altura = double.Parse(Console.ReadLine());

        r.ExibirDados();
    }
}



