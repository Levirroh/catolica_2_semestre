// Classe derivada 1 - Conta Corrente
public class ContaCorrente : Conta
{
    public decimal LimiteChequeEspecial { get; set; }

    public ContaCorrente(int numero, string titular, decimal limite = 500m) 
        : base(numero, titular)
    {
        LimiteChequeEspecial = limite;
    }

    // Sobrescrevendo o método Sacar para considerar o cheque especial
    public override bool Sacar(decimal valor)
    {
        decimal saldoDisponivel = Saldo + LimiteChequeEspecial;

        if (valor > 0 && valor <= saldoDisponivel)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} na Conta Corrente realizado. " +
                $"Saldo atual: R${Saldo} (limite disponível: R${LimiteChequeEspecial + Saldo})");
            return true;
        }
        else
        {
            Console.WriteLine("Saque não permitido. Limite de cheque especial excedido.");
            return false;
        }
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"=== CONTA CORRENTE ===");
        base.ExibirResumo();
        Console.WriteLine($"Limite de Cheque Especial: R${LimiteChequeEspecial}");
    }
}
