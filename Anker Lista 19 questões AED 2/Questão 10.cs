using System;

class CalculoDeInvestimentoQ10
{
    static void Main()
    {
        //Solicita o valor investido e a % do juros
        Console.Write("Valor investido por mês: ");
        double aporte = double.Parse(Console.ReadLine());

        Console.Write("Taxa de juros mensal (%): ");
        double taxa = double.Parse(Console.ReadLine()) / 100.0;

        double saldo = 0;
        string resposta;

        do
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                saldo += aporte;          // adiciona o valor do mês
                saldo += saldo * taxa;    // aplica juros sobre o saldo total
            }

            Console.WriteLine("\nSaldo do investimento após 1 ano: " + saldo);

            Console.Write("Deseja processar mais um ano? (S/N): ");
            resposta = Console.ReadLine().ToUpper();

        } while (resposta == "S");
    }
}
