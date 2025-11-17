using System;

// Programa principal para testar
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TESTANDO HERANÇA EM C# ===\n");

        ContaCorrente cc = new ContaCorrente(111, "João Silva", 1000m);
        ContaPoupanca cp = new ContaPoupanca(222, "Maria Oliveira", 0.006m);

        // Testando Conta Corrente
        cc.Depositar(300);
        cc.Sacar(500);      // usa cheque especial
        cc.Sacar(900);      // ainda dentro do limite
        cc.ExibirResumo();

        Console.WriteLine();

        // Testando Conta Poupança
        cp.Depositar(2000);
        cp.AplicarRendimento();
        cp.Sacar(500);
        cp.ExibirResumo();

        // Polimorfismo: tratando como Conta (classe base)
        Console.WriteLine("\n--- Polimorfismo ---");
        Conta conta1 = cc;
        Conta conta2 = cp;

        conta1.ExibirResumo(); // chama o método sobrescrito da ContaCorrente
        conta2.ExibirResumo(); // chama o método sobrescrito da ContaPoupanca

        Console.ReadKey();
    }
}