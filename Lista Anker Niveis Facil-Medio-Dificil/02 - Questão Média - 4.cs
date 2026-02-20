using System;

class Animal
{
    private string nome;
    private string tipo;

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetTipo()
    {
        return tipo;
    }

    // Tipos válidos: cachorro, gato e peixe
    public void SetTipo(string tipo)
    {
        string tipoMinusculo = tipo.ToLower();

        if (tipoMinusculo == "cachorro" || tipoMinusculo == "gato" || tipoMinusculo == "peixe")
        {
            this.tipo = tipoMinusculo;
        }
        else
        {
            // Tipo inválido
            this.tipo = "peixe";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Animal[] animais = new Animal[5];

        for (int i = 0; i < 5; i++)
        {
            // Criando objeto da classe Animal para cada posição
            animais[i] = new Animal();

            Console.WriteLine("Animal " + (i + 1));

            Console.Write("Nome: ");
            animais[i].SetNome(Console.ReadLine());

            Console.Write("Tipo (cachorro, gato, peixe): ");
            animais[i].SetTipo(Console.ReadLine());

            Console.WriteLine();
        }


        int cachorros = 0;
        int gatos = 0;
        int peixes = 0;

        // Percorre os animais e conta cada tipo
        for (int i = 0; i < 5; i++)
        {
            if (animais[i].GetTipo() == "cachorro")
            {
                cachorros++;
            }
            else if (animais[i].GetTipo() == "gato")
            {
                gatos++;
            }
            else
            {
                peixes++;
            }
        }


        Console.WriteLine("=== RESULTADO ===");
        Console.WriteLine("Cachorros: " + cachorros);
        Console.WriteLine("Gatos: " + gatos);
        Console.WriteLine("Peixes: " + peixes);
    }
}

