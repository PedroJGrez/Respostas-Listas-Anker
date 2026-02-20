using System;


class Extrato
{
    private string data;
    private double valor;

    public Extrato(string data, double valor)
    {
        this.data = data;
        this.valor = valor;
    }

    public string GetData()
    {
        return data;
    }

    public double GetValor()
    {
        return valor;
    }
}

//guarda número e validade do cartão
class Cartao
{
    private string numero;
    private string validade;

    public Cartao(string numero, string validade)
    {
        this.numero = numero;
        this.validade = validade;
    }

    public string GetNumero()
    {
        return numero;
    }

    public string GetValidade()
    {
        return validade;
    }
}


class Conta
{
    private string nomeCliente;
    private int numeroConta;
    private double saldo;

    //Vetor de 1000 posições para o extrato
    private Extrato[] extratos;
    private int totalExtratos;

    //Informação do cartão vinculado à conta
    private Cartao cartao;

    //Construtor recebe nome, número e saldo inicial
    public Conta(string nomeCliente, int numeroConta, double saldo)
    {
        this.nomeCliente = nomeCliente;
        this.numeroConta = numeroConta;
        this.saldo = saldo;
        this.extratos = new Extrato[1000];
        this.totalExtratos = 0;
        this.cartao = null;
    }

    public double ObterSaldo()
    {
        return saldo;
    }

    public int ObterNumero()
    {
        return numeroConta;
    }

    public string ObterNomeCliente()
    {
        return nomeCliente;
    }

    public void SetCartao(Cartao cartao)
    {
        this.cartao = cartao;
    }

    public Cartao GetCartao()
    {
        return cartao;
    }

    //Método depositar
    public void Depositar(double valor)
    {
        saldo = saldo + valor;

        string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        extratos[totalExtratos] = new Extrato(dataAtual, valor);
        totalExtratos++;

        Console.WriteLine("Deposito de R$" + valor + " realizado com sucesso!");
    }

    //Método sacar
    public void Sacar(double valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para saque!");
        }
        else
        {
            saldo = saldo - valor;

            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //saída de dinheiro
            extratos[totalExtratos] = new Extrato(dataAtual, -valor);
            totalExtratos++;

            Console.WriteLine("Saque de R$" + valor + " realizado com sucesso!");
        }
    }

    //verifica se o cartão pertence à conta
    public void SacarComCartao(double valor, string numeroCartao, string validadeCartao)
    {
        if (cartao == null)
        {
            Console.WriteLine("Esta conta nao possui cartao vinculado!");
        }
        else if (cartao.GetNumero() != numeroCartao || cartao.GetValidade() != validadeCartao)
        {
            Console.WriteLine("Cartao invalido! Numero ou validade incorretos.");
        }
        else
        {
            Console.WriteLine("Cartao identificado! Realizando saque...");
            Sacar(valor);
        }
    }

    //Exibe número, titular, saldo e extrato
    public void ExibirRelatorio()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Numero da conta: " + numeroConta);
        Console.WriteLine("Titular: " + nomeCliente);
        Console.WriteLine("Saldo atual: R$" + saldo);

        if (cartao != null)
        {
            Console.WriteLine("Cartao: " + cartao.GetNumero() + " | Validade: " + cartao.GetValidade());
        }
        else
        {
            Console.WriteLine("Cartao: Nao vinculado");
        }

        Console.WriteLine("Extrato:");
        if (totalExtratos == 0)
        {
            Console.WriteLine("  Nenhuma movimentacao");
        }
        else
        {
            for (int i = 0; i < totalExtratos; i++)
            {
                if (extratos[i].GetValor() >= 0)
                {
                    Console.WriteLine("  " + extratos[i].GetData() + " | Deposito: R$" + extratos[i].GetValor());
                }
                else
                {
                    Console.WriteLine("  " + extratos[i].GetData() + " | Saque: R$" + (extratos[i].GetValor() * -1));
                }
            }
        }
        Console.WriteLine("-----------------------------");
    }
}

class Teste
{
    static void Main(string[] args)
    {
        //3 contas diferentes
        Conta conta1 = new Conta("Carlos Silva", 1001, 500);
        Conta conta2 = new Conta("Ana Souza", 1002, 1000);
        Conta conta3 = new Conta("Pedro Lima", 1003, 250);

        // Realizando operações de depósito e saque
        Console.WriteLine("=== OPERACOES ===");
        conta1.Depositar(200);
        conta1.Sacar(100);
        conta1.Sacar(700); // Saldo insuficiente

        conta2.Depositar(500);
        conta2.Sacar(300);

        conta3.Depositar(150);
        conta3.Sacar(50);

        // Criando e vinculando cartões às contas
        Cartao cartao1 = new Cartao("1111-2222-3333-4444", "12/27");
        Cartao cartao2 = new Cartao("5555-6666-7777-8888", "06/26");
        Cartao cartao3 = new Cartao("9999-0000-1111-2222", "09/25");

        conta1.SetCartao(cartao1);
        conta2.SetCartao(cartao2);
        conta3.SetCartao(cartao3);


        Console.WriteLine("\n=== SAQUES COM CARTAO ===");
        Console.WriteLine("Tentando saque na conta 1 com cartao correto:");
        conta1.SacarComCartao(50, "1111-2222-3333-4444", "12/27");

        Console.WriteLine("Tentando saque na conta 2 com cartao errado:");
        conta2.SacarComCartao(100, "0000-0000-0000-0000", "01/01");

        Console.WriteLine("Tentando saque na conta 3 com cartao correto:");
        conta3.SacarComCartao(30, "9999-0000-1111-2222", "09/25");


        Console.WriteLine("\n=== RELATORIO FINAL ===");
        conta1.ExibirRelatorio();
        conta2.ExibirRelatorio();
        conta3.ExibirRelatorio();
    }
}

