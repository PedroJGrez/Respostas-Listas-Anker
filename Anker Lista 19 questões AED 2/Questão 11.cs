Console.Write("De qual número você quer a raiz? ");
double numero = double.Parse(Console.ReadLine());

Console.Write("Qual o erro máximo aceito? (ex: 0,1): ");
double erro = double.Parse(Console.ReadLine());

// No começo usamos um numero qualquer
double chute = numero;

// Agora uma conta simples para ver a diferença
double diferenca = (chute * chute) - numero;
if (diferenca < 0) diferenca = -diferenca;

while (diferenca > erro)
{
    // Ajustamos o chute usando a média (lógica de Newton)
    chute = (chute + (numero / chute)) / 2;

    // Atualizamos a diferença para o próximo teste do 'while'
    diferenca = (chute * chute) - numero;
    if (diferenca < 0) diferenca = -diferenca;
}

Console.WriteLine($"A raiz aproximada é: {chute}");