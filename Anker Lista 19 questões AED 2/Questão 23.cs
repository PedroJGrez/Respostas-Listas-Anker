class Figura
{
    protected string nome;

    protected Figura(string nome)
    {
        this.nome = nome;
    }

    // Método virtual sobrescrito pelas filhas
    protected virtual double CalcularArea()
    {
        return 0;
    }

    // Herdado por todas as filhas — escrito UMA vez só aqui
    public void Exibir()
    {
        Console.WriteLine($"{nome}: área = {CalcularArea():F2}");
    }
}

// Herda nome e Exibir() de Figura
class Quadrado : Figura
{
    private double lado;

    public Quadrado(double lado) : base("Quadrado") // chama o construtor do pai
    {
        this.lado = lado;
    }

    protected override double CalcularArea()
    {
        return lado * lado;
    }
}

// Herda nome e Exibir() de Figura
class Retangulo : Figura
{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura) : base("Retângulo")
    {
        this.largura = largura;
        this.altura = altura;
    }

    protected override double CalcularArea()
    {
        return largura * altura;
    }
}

// Herda nome e Exibir() de Figura
class Triangulo : Figura
{
    private double baseT;
    private double altura;

    public Triangulo(double baseT, double altura) : base("Triângulo")
    {
        this.baseT = baseT;
        this.altura = altura;
    }

    protected override double CalcularArea()
    {
        return (baseT * altura) / 2;
    }
}

// Herda nome e Exibir() de Figura
class Circulo : Figura
{
    private double raio;

    public Circulo(double raio) : base("Círculo")
    {
        this.raio = raio;
    }

    protected override double CalcularArea()
    {
        return Math.PI * raio * raio;
    }

    static void Main()
    {
        // Polimorfismo: tratados como Figura, comportamento diferente em cada um
        Figura[] figuras = {
            new Quadrado(5),
            new Retangulo(4, 7),
            new Triangulo(6, 3),
            new Circulo(4)
        };

        Console.WriteLine("=== Áreas das Figuras ===");
        foreach (Figura f in figuras)
            f.Exibir(); // herdado de Figura, CalcularArea() é de cada um
    }
}