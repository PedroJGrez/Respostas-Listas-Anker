// Pede ao usuario as informações dos produtos
Console.Write("Digite o nome do produto: ");
string nome = Console.ReadLine();

Console.Write("Digite o preço unitário: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine());

//Descontos
double percentualDesconto;

if (quantidade <= 10)
    percentualDesconto = 0.0;
else if (quantidade <= 20)
    percentualDesconto = 0.10;
else if (quantidade <= 50)
    percentualDesconto = 0.20;
else
    percentualDesconto = 0.25;

//Cálculos baseado nas informações adquiridas
double valorBruto = preco * quantidade;
double valorDesconto = valorBruto * percentualDesconto;
double valorFinal = valorBruto - valorDesconto;

// 4. Exibição amigável
Console.WriteLine("\n--- Resumo da Venda ---");
Console.WriteLine($"Produto: {nome}");
Console.WriteLine($"Valor Final: R$ {valorFinal}");

if (percentualDesconto > 0)
{
    Console.WriteLine($"Desconto aplicado: {percentualDesconto * 100}% (R$ {valorDesconto} de economia)");
}