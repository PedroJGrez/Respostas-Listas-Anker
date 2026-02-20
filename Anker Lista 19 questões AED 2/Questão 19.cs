//Classes identificadas: Produto, item produto, pedido

using System;

// Representa um produto do supermercado
class Produto
{
    public string Nome;
    public double Preco;
    public int Estoque;

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}

// Representa um item do pedido (qual produto e quanto o cliente quer)
class ItemPedido
{
    public Produto Produto;
    public int Quantidade;

    public ItemPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }
}

// Representa o pedido do cliente
class Pedido
{
    public ItemPedido[] Itens = new ItemPedido[10]; // máximo 10 itens
    public int TotalItens = 0;
    public string Pagamento = "";

    // Adiciona um item ao pedido
    public void AdicionarItem(Produto produto, int quantidade)
    {
        Itens[TotalItens] = new ItemPedido(produto, quantidade);
        TotalItens++;
    }

    // Calcula o total somando todos os itens
    public double CalcularTotal()
    {
        double total = 0;
        for (int i = 0; i < TotalItens; i++)
            total += Itens[i].Produto.Preco * Itens[i].Quantidade;
        return total;
    }

    // Imprime o resumo do pedido
    public void ImprimirCupom()
    {
        Console.WriteLine("\n===== CUPOM DO PEDIDO =====");
        for (int i = 0; i < TotalItens; i++)
        {
            double subtotal = Itens[i].Produto.Preco * Itens[i].Quantidade;
            Console.WriteLine($"{Itens[i].Produto.Nome} x{Itens[i].Quantidade} = R$ {subtotal:F2}");
        }
        Console.WriteLine($"TOTAL: R$ {CalcularTotal():F2}");
        Console.WriteLine($"Pagamento: {Pagamento}");
        Console.WriteLine("===========================\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Cadastra alguns produtos
        Produto[] produtos = new Produto[3];
        produtos[0] = new Produto("Arroz 5kg", 25.90, 50);
        produtos[1] = new Produto("Feijão 1kg", 8.50, 30);
        produtos[2] = new Produto("Leite 1L", 4.99, 60);

        Pedido pedido = new Pedido();

        // Mostra os produtos disponíveis
        Console.WriteLine("===== PRODUTOS =====");
        for (int i = 0; i < produtos.Length; i++)
            Console.WriteLine($"{i + 1}. {produtos[i].Nome} - R$ {produtos[i].Preco:F2}");

        // Adiciona um item ao pedido
        Console.Write("\nNúmero do produto: ");
        int escolha = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        pedido.AdicionarItem(produtos[escolha], quantidade);

        // Forma de pagamento
        Console.WriteLine("\nForma de pagamento:");
        Console.WriteLine("1. Dinheiro");
        Console.WriteLine("2. Cheque");
        Console.WriteLine("3. Cartão");
        Console.Write("Opção: ");
        string op = Console.ReadLine();

        if (op == "1") pedido.Pagamento = "Dinheiro";
        else if (op == "2") pedido.Pagamento = "Cheque";
        else pedido.Pagamento = "Cartão";

        // Imprime o cupom final
        pedido.ImprimirCupom();
    }
}