Console.Write("Digite um número inteiro: ");
int numeroOriginal = int.Parse(Console.ReadLine());

// Salvamos o numero original em uma variavel e usamos o math.abs para conseguir lermos numeros negativos

int numero = Math.Abs(numeroOriginal);
int contadorDigitos = 0;

// se o número for 0, ele tem 1 dígito.
if (numero == 0)
{
    contadorDigitos = 1;
}
else
{
    // Enquanto o número for maior que zero, dividimos por 10
    while (numero > 0)
    {
        numero = numero / 10; // Isso remove o último dígito
        contadorDigitos++;     // Contamos que um dígito foi removido
    }
}

Console.WriteLine($"O número {numeroOriginal} tem {contadorDigitos} dígito(s).");