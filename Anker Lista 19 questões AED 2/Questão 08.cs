using System;

class TremDeFibonacci
{
    static void Main()
    {
        Console.Write("Informe um número inteiro não negativo: ");
        int n = int.Parse(Console.ReadLine());

        //Caso seja um numero negativo
        if (n < 0)
        {
            Console.WriteLine("Número inválido!");
            return;
        }
        //Definimos o valor inicial da sequencia
        long f0 = 0;
        long f1 = 1;

        //Estrutura de repetição, quantas vezes ira se repetir, ex: usuario digitou 9 (n = 9) então ira se repetir 9 vezes, por isso a condição i <= 9
        for (int i = 0; i <= n; i++)
        {
            if (i == 0)
            {
                Console.Write(f0);
            }
            else if (i == 1)
            {
                Console.Write(", " + f1);
            }
            else
            {
                // A sequencia começa com 0 e 1, depois cada numero se torna a soma dos ultimos dois numeros (f0 e f1)
                long fn = f0 + f1;
                Console.Write(", " + fn);

                f0 = f1;
                f1 = fn;
            }
        }
    }
}
