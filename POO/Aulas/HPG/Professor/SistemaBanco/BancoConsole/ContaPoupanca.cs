// Classe derivada 2 - Conta Poupança
public class ContaPoupanca : Conta
{
    public decimal TaxaRendimento { get; set; } // ex: 0.005m = 0,5% ao mês

    public ContaPoupanca(int numero, string titular, decimal taxa = 0.005m) 
        : base(numero, titular)
    {
        TaxaRendimento = taxa;
    }

    // Método específico da poupança
    public void AplicarRendimento()
    {
        decimal rendimento = Saldo * TaxaRendimento;
        Saldo += rendimento;
        Console.WriteLine($"Rendimento de R${rendimento:F2} aplicado! Novo saldo: R${Saldo}");
    }

    // Poupança normalmente não permite saque se não houver saldo (sem cheque especial)
    public override bool Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} na Conta Poupança realizado. Novo saldo: R${Saldo}");
            return true;
        }
        else
        {
            Console.WriteLine("Saque não permitido na poupança (saldo insuficiente).");
            return false;
        }
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"=== CONTA POUPANÇA ===");
        base.ExibirResumo();
        Console.WriteLine($"Taxa de rendimento mensal: {TaxaRendimento:P2}");
    }
}