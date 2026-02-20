using System;

class Lampada
{
    private bool ligada;

    public Lampada()
    {
        ligada = false;
    }

    public void Ligar()
    {
        ligada = true;
    }

    public void Desligar()
    {
        ligada = false;
    }

    public bool GetEstado()
    {
        return ligada;
    }

    public void ExibirEstado()
    {
        if (ligada)
            Console.WriteLine("Estado: Ligada");
        else
            Console.WriteLine("Estado: Desligada");
    }
}

class LampadaEspecial : Lampada
{
    private double potencia;
    private double voltagem;
    private bool queimada;

    public LampadaEspecial(double potencia, double voltagem)
    {
        this.potencia = potencia;
        this.voltagem = voltagem;
        this.queimada = false;
    }

    public double GetPotencia() { return potencia; }
    public void SetPotencia(double potencia) { this.potencia = potencia; }

    public double GetVoltagem() { return voltagem; }
    public void SetVoltagem(double voltagem) { this.voltagem = voltagem; }

    public bool GetQueimada() { return queimada; }

    public new void ExibirEstado()
    {
        if (queimada)
        {
            Console.WriteLine("Estado: Queimada");
        }
        else
        {
            base.ExibirEstado();
        }
        Console.WriteLine("Potencia: " + potencia + "W");
        Console.WriteLine("Voltagem: " + voltagem + "V");
    }

    public void TentarLigar()
    {
        // Não liga mais se queimar
        if (queimada)
        {
            Console.WriteLine("Impossivel ligar: a lampada esta queimada!");
            return;
        }

        Random random = new Random();
        int numero = random.Next(1, 101);

        if (numero <= 15)
        {
            queimada = true;
            Console.WriteLine("A lampada queimou ao ser ligada!");
        }
        else
        {
            Ligar();
            Console.WriteLine("Lampada ligada com sucesso!");
        }
    }
}

class Teste
{
    static void Main(string[] args)
    {
        LampadaEspecial lampada = new LampadaEspecial(60, 127);

        Console.WriteLine("=== Estado inicial ===");
        lampada.ExibirEstado();

        Console.WriteLine("\n=== Tentando ligar a lampada ===");
        lampada.TentarLigar();

        Console.WriteLine("\n=== Estado apos tentar ligar ===");
        lampada.ExibirEstado();


        if (lampada.GetQueimada())
        {
            Console.WriteLine("\n=== Tentando ligar novamente ===");
            lampada.TentarLigar();
        }
    }
}

