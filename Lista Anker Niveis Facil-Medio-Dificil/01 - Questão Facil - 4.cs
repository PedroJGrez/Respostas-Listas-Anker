using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 1;

        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 2; i < 30; i++)
        {
            int proximo = a + b;
            Console.WriteLine(proximo);
            a = b;
            b = proximo;
        }
    }
}
