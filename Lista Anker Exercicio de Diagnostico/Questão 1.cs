using System;

// a) Classe Veiculo com todos os atributos solicitados
public class Veiculo
{
    // Atributos privados conforme enunciado
    private int quantOcupantes;
    private int quantRodas;
    private float capacidadeTanque;   // Capacidade máxima do tanque (litros)
    private float nivelTanque;        // Nível atual do tanque em percentual
    private float consumoMedio;       // Consumo em km/litro
    private float quilometragem;      // Quilometragem atual do veículo
    private float autonomia;          // Quantidade de km que ainda pode percorrer

    // b) Métodos get/set para TODOS os atributos

    public int GetQuantOcupantes() { return quantOcupantes; }
    public void SetQuantOcupantes(int valor) { quantOcupantes = valor; }

    public int GetQuantRodas() { return quantRodas; }
    public void SetQuantRodas(int valor) { quantRodas = valor; }

    public float GetCapacidadeTanque() { return capacidadeTanque; }
    public void SetCapacidadeTanque(float valor) { capacidadeTanque = valor; }

    public float GetNivelTanque() { return nivelTanque; }
    public void SetNivelTanque(float valor) { nivelTanque = valor; }

    // b) get/set para consumo médio - exigido pelo enunciado
    public float GetConsumoMedio() { return consumoMedio; }
    public void SetConsumoMedio(float valor) { consumoMedio = valor; }

    // b) get/set para quilometragem - exigido pelo enunciado
    public float GetQuilometragem() { return quilometragem; }
    public void SetQuilometragem(float valor) { quilometragem = valor; }

    public float GetAutonomia() { return autonomia; }
    public void SetAutonomia(float valor) { autonomia = valor; }
}

// c) Classe Carro derivada de Veiculo, com modelo e quantidade de portas
public class Carro : Veiculo
{
    private string modelo;
    private int quantPortas;

    // d) Construtor padrão (default)
    public Carro() { }

    // d) Construtor completo com todos os atributos da classe
    public Carro(int quantOcupantes, int quantRodas, float capacidadeTanque,
                 float nivelTanque, float consumoMedio, float quilometragem,
                 float autonomia, string modelo, int quantPortas)
    {
        SetQuantOcupantes(quantOcupantes);
        SetQuantRodas(quantRodas);
        SetCapacidadeTanque(capacidadeTanque);
        SetNivelTanque(nivelTanque);
        SetConsumoMedio(consumoMedio);
        SetQuilometragem(quilometragem);
        SetAutonomia(autonomia);
        this.modelo = modelo;
        this.quantPortas = quantPortas;
    }

    public string GetModelo() { return modelo; }
    public void SetModelo(string valor) { modelo = valor; }

    public int GetQuantPortas() { return quantPortas; }
    public void SetQuantPortas(int valor) { quantPortas = valor; }

    // e) Método Percorrer retorna float (quilometragem atual) conforme enunciado
    // Limite de quilometragem: 999.999 km
    public float Percorrer(float qtdQuilometros)
    {
        // Calcula autonomia atual com base no nível atual do tanque
        float autonomiaAtual = (GetNivelTanque() / 100f) * GetCapacidadeTanque() * GetConsumoMedio();

        // Validação: não pode percorrer mais do que a autonomia atual permite
        if (qtdQuilometros > autonomiaAtual)
        {
            Console.WriteLine("ERRO: Quilômetros solicitados excedem a autonomia atual do veículo!");
            Console.WriteLine($"Autonomia disponível: {autonomiaAtual:F2} km");
            return GetQuilometragem(); // Retorna quilometragem sem alteração
        }

        // Atualiza quilometragem respeitando o limite de 999.999 km
        float novaKm = GetQuilometragem() + qtdQuilometros;
        if (novaKm > 999999f)
            SetQuilometragem(999999f);
        else
            SetQuilometragem(novaKm);

        // Atualiza nível do tanque após percorrer
        float litrosConsumidos = qtdQuilometros / GetConsumoMedio();
        float novoNivel = GetNivelTanque() - (litrosConsumidos / GetCapacidadeTanque() * 100f);
        if (novoNivel < 0) novoNivel = 0;
        SetNivelTanque(novoNivel);

        // Recalcula autonomia restante
        SetAutonomia((novoNivel / 100f) * GetCapacidadeTanque() * GetConsumoMedio());

        // e) Retorna a quilometragem atual do carro
        return GetQuilometragem();
    }
}

public class Program
{
    public static void Main()
    {
        // Teste com construtor completo
        // Autonomia inicial = 0.8 * 50 * 12.5 = 500 km
        Carro carro1 = new Carro(5, 4, 50.0f, 80.0f, 12.5f, 1000.0f, 500.0f, "Gol", 4);

        Console.WriteLine("=== Dados do Carro ===");
        Console.WriteLine($"Modelo: {carro1.GetModelo()}");
        Console.WriteLine($"Portas: {carro1.GetQuantPortas()}");
        Console.WriteLine($"Ocupantes: {carro1.GetQuantOcupantes()}");
        Console.WriteLine($"Rodas: {carro1.GetQuantRodas()}");
        Console.WriteLine($"Cap. Tanque: {carro1.GetCapacidadeTanque()}L");
        Console.WriteLine($"Nível Tanque: {carro1.GetNivelTanque()}%");
        Console.WriteLine($"Consumo: {carro1.GetConsumoMedio()} km/L");
        Console.WriteLine($"Quilometragem: {carro1.GetQuilometragem()} km");
        Console.WriteLine($"Autonomia: {carro1.GetAutonomia():F2} km");

        Console.WriteLine("\n=== Teste: Percorrer 300 km ===");
        float kmRetornada = carro1.Percorrer(300);
        Console.WriteLine($"Quilometragem atual retornada pelo método: {kmRetornada} km");
        Console.WriteLine($"Nível do tanque após viagem: {carro1.GetNivelTanque():F2}%");
        Console.WriteLine($"Autonomia restante: {carro1.GetAutonomia():F2} km");

        Console.WriteLine("\n=== Teste: Percorrer 1000000 km ===");
        float kmRetornada2 = carro1.Percorrer(1000000);
        Console.WriteLine($"Quilometragem atual: {kmRetornada2} km");

        Console.WriteLine("\n=== Teste com construtor padrão + setters ===");
        Carro carro2 = new Carro();
        carro2.SetModelo("Civic");
        carro2.SetQuantPortas(4);
        carro2.SetQuantOcupantes(5);
        carro2.SetQuantRodas(4);
        carro2.SetCapacidadeTanque(47.0f);
        carro2.SetNivelTanque(100.0f);
        carro2.SetConsumoMedio(14.0f);
        carro2.SetQuilometragem(0.0f);
        carro2.SetAutonomia(47.0f * 14.0f);
        Console.WriteLine($"Modelo: {carro2.GetModelo()} | Autonomia: {carro2.GetAutonomia()} km");
    }
}

