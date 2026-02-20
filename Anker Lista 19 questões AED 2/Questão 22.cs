class Pessoa
{
    private string nome;
    private int idade;
    private Pessoa pai;
    private Pessoa mae;

    // Construtor sem pais (topo da árvore)
    private Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    // Construtor com pais
    private Pessoa(string nome, int idade, Pessoa pai, Pessoa mae)
    {
        this.nome = nome;
        this.idade = idade;
        this.pai = pai;
        this.mae = mae;
    }

    // Exibe a árvore completa de forma recursiva
    private void ExibirArvore(int nivel = 0)
    {
        string espaco = new string(' ', nivel * 4);
        Console.WriteLine($"{espaco}+-- {nome} ({idade} anos)");

        if (pai != null) pai.ExibirArvore(nivel + 1);
        if (mae != null) mae.ExibirArvore(nivel + 1);
    }

    static void Main()
    {
        // Avós (sem pais cadastrados)
        Pessoa avoPaterno = new Pessoa("José", 75);
        Pessoa avoPaterna = new Pessoa("Maria", 70);
        Pessoa avoMaterno = new Pessoa("Antônio", 78);
        Pessoa avoMaterna = new Pessoa("Lúcia", 72);

        // Pais
        Pessoa pai = new Pessoa("Carlos", 50, avoPaterno, avoPaterna);
        Pessoa mae = new Pessoa("Ana", 48, avoMaterno, avoMaterna);

        // Filho
        Pessoa filho = new Pessoa("Lucas", 25, pai, mae);

        // Exibindo a árvore
        Console.WriteLine("=== Árvore Genealógica ===");
        filho.ExibirArvore();
    }
}