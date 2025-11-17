// Classe base (classe pai)
public class Conta
{
    public int Numero { get; set; }
    public string Titular { get; set; }
    protected decimal Saldo { get; set; }  // protected para as filhas acessarem diretamente

    public Conta(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        Saldo = 0m;
    }

    // Método que pode ser sobrescrito (virtual)
    public virtual void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado. Novo saldo: R${Saldo}");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    // Método que pode ser sobrescrito
    public virtual bool Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado. Novo saldo: R${Saldo}");
            return true;
        }
        else
        {
            Console.WriteLine("Saque não permitido (saldo insuficiente ou valor inválido).");
            return false;
        }
    }

    public decimal ConsultarSaldo()
    {
        return Saldo;
    }

    public virtual void ExibirResumo()
    {
        Console.WriteLine($"Conta: {Numero} | Titular: {Titular} | Saldo: R${Saldo}");
    }
}
