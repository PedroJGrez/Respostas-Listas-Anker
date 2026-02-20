Console.WriteLine("=== TABUADA DE 1 A 10 ===\n");

// O i começa no 1 e vai aumentando até chegar no 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"--- Tabuada do {i} ---");

    // Praticamente a mesma coisa com o j, ele começa no 1 e vai aumentando até chegar no 10
    for (int j = 1; j <= 10; j++)
    {
        int resultado = i * j;
        // A lógica seria: o i avança um número e o j avança até o 10 a cada avanço unico do i, como se o i fosse o ponteiro menor de um relógio e o j o ponteiro maior
        // Aqui exibe o resultado de uma forma melhor para se entender
        Console.WriteLine($"{i} x {j} = {resultado}");
    }

    Console.WriteLine();
}
