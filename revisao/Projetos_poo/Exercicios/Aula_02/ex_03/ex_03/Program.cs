const int max_produtos = 40;
decimal[] precos_produtos = new decimal[max_produtos];
string[] nome_produtos = new string[max_produtos];
int[] quantidade_produtos = new int[max_produtos];
int[] vendidos_produtos = new int[max_produtos];
string[] classificacoes_atletas = new string[max_produtos];

Console.WriteLine("Olá, bem-vindo ao Sistema de Gerenciamento de Vendas!");
Console.WriteLine("--------");
Console.WriteLine("Aperte qualquer tecla para começar a preencher os dados! \n");

Console.ReadKey();

Console.WriteLine("--------");


int total_produtos = entrada_de_dados(nome_produtos, quantidade_produtos, precos_produtos, max_produtos);

calculo_de_medias();

verificacao_de_vendas();

geracao_de_relatorio();

Console.Clear();

static int entrada_de_dados(string[] nome_produtos, int[] quantidade_produtos, decimal[] precos_produtos, int max_produtos)
{
    int produto = 0 ;
    string sair = "";
    decimal preco = 0;
    string nome = "";
    int quantidade = 0;

    Console.Clear();
    while (sair != "1" && produto <= max_produtos)
    {
        Console.WriteLine($"Digite o nome do {produto + 1}º produto");
        nome = Console.ReadLine();

        if (!string.IsNullOrEmpty(nome))
        {
            Console.WriteLine($"Digite o preco do produto {nome} (0 a 1000):");
            preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a quantidade do produto {nome}");
            quantidade = int.Parse(Console.ReadLine());

            if (preco >= 0 && preco <= 1000)
            {
                precos_produtos[produto] = preco;
                nome_produtos[produto] = nome;
                quantidade_produtos[produto] = quantidade;
                Console.WriteLine("Deseja finalizar a inserção de dados? Digite [1] para sair ou qualquer outra tecla para continuar.");
                sair = Console.ReadLine();
                produto++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Pontuação inválida! Digite um número entre 0 e 1000.");
            }
        }
        else
        {
            Console.WriteLine("Erro: O nome não pode ser vazio, aperte qualquer tecla para inserir o nome novamente.");
            Console.ReadLine();
        }
    }
    return produto;

}

static decimal calculo_de_medias()
{
    return 0;
}

static void verificacao_de_vendas()
{
    return;
}

static void geracao_de_relatorio()
{
    return;
    
}

