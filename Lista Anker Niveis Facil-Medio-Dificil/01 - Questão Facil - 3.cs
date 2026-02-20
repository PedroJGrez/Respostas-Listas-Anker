using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

