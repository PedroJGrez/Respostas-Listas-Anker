using System;

class Pessoa
{
    private string nome;
    private int idade;

    // Construtor sem parâmetros
    public Pessoa()
    {
        nome = "";
        idade = 0;
    }

    // Construtor com nome e idade
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + nome + " | Idade: " + idade);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa[] pessoas = new Pessoa[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Pessoa " + (i + 1));

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            pessoas[i] = new Pessoa(nome, idade);
            Console.WriteLine();
        }

        Pessoa maisVelha = pessoas[0];

        for (int i = 1; i < 3; i++)
        {
            if (pessoas[i].GetIdade() > maisVelha.GetIdade())
            {
                maisVelha = pessoas[i];
            }
        }

        Console.WriteLine("Pessoa com maior idade:");
        maisVelha.ExibirDados();
    }
}

