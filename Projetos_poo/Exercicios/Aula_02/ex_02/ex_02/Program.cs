const int max_atletas = 20;
int[,] pontuacoes_atletas = new int[max_atletas, 3];//pt1,pt2,pt3.
string[] nomes_atletas = new string[max_atletas];//nomes
decimal[] media_atletas = new decimal[max_atletas];//media.
string[] classificacoes_atletas = new string[max_atletas];//classificacoes finais.

Console.WriteLine("Olá, bem-vindo ao Sistema de Avaliação de Atletas!");
Console.WriteLine("--------");
Console.WriteLine("Aperte qualquer tecla para começar a preencher os dados da competição! \n");

Console.ReadKey();

Console.WriteLine("--------");


int total_atletas = entrada_de_dados(max_atletas, pontuacoes_atletas, nomes_atletas);

decimal media_total = calculo_de_medias(pontuacoes_atletas, total_atletas, media_atletas);

verificacao_de_classificacao(media_atletas, total_atletas, classificacoes_atletas);

geracao_de_relatorio(nomes_atletas, pontuacoes_atletas, media_atletas, classificacoes_atletas, total_atletas, media_total);

Console.Clear();

//entrada
static int entrada_de_dados(int max_atletas, int[,]pontuacoes_atletas, string[] nomes_atletas)
{
    int atleta = 0 ;
    string sair = "";
    int pontuacao = 0;
    Console.Clear();
    while (sair != "1" && atleta <= max_atletas)
    {
        Console.WriteLine($"Digite o nome do {atleta + 1}º atleta");
        nomes_atletas[atleta] = Console.ReadLine();

        if (!string.IsNullOrEmpty(nomes_atletas[atleta]))
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite a {j + 1}ª pontuação do {nomes_atletas[atleta]} (0 a 100):");
                pontuacao = int.Parse(Console.ReadLine());
                if (pontuacao >= 0 && pontuacao <= 100)
                {
                    pontuacoes_atletas[atleta, j] = pontuacao;
                }
                else
                {
                    Console.WriteLine("Pontuação inválida! Digite um número entre 0 e 100.");
                    j--;
                }
            }
            Console.WriteLine("Deseja finalizar a inserção de dados? Digite [1] para sair ou qualquer outra tecla para continuar.");
            sair = Console.ReadLine();
            atleta++;
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Erro: O nome não pode ser vazio, aperte qualquer tecla para inserir o nome novamente.");
            Console.ReadLine();
        }
    }
    return atleta;
}

static decimal calculo_de_medias(int[,] pontuacoes_atletas, int total_atletas, decimal[] media_atletas)
{
    decimal media_total = 0;
    for (int i = 0; i < total_atletas; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            media_atletas[i] += (decimal)pontuacoes_atletas[i, j];
        }
        media_atletas[i] /= 3;
        media_total += media_atletas[i];
    }

    media_total /= total_atletas;
    return media_total;
}

static void verificacao_de_classificacao(decimal[] media_atletas, int total_atletas, string[] classificacoes_atletas)
{
    for (int i = 0; i < total_atletas; i++)
    {
        if (media_atletas[i] >= 70) {
            classificacoes_atletas[i] = "Aprovado";
        }
        else{
            classificacoes_atletas[i] = "Reprovado";
        }
    }
}

static void geracao_de_relatorio(string[] nomes_atletas, int[,] pontuacoes_atletas, decimal[] media_atletas, string[] classificacoes_atletas, int total_atletas, decimal media_total)
{
    int aprovados = 0;

    Console.WriteLine("-------- RELATÓRIO FINAL --------\n");

    for (int i = 0; i < total_atletas; i++)
    {
        Console.WriteLine($"Atleta {i + 1}: {nomes_atletas[i]}");
        Console.WriteLine($"Pontuações: {pontuacoes_atletas[i, 0]}, {pontuacoes_atletas[i, 1]}, {pontuacoes_atletas[i, 2]}");
        Console.WriteLine($"Média: {media_atletas[i]}");
        Console.WriteLine($"Classificação: {classificacoes_atletas[i]}\n");

        if (classificacoes_atletas[i] == "Aprovado")
        {
            aprovados++;
        }
    }

    decimal percentual_aprovados = ((decimal)aprovados / total_atletas) * 100;

    Console.WriteLine($"Média geral da competição: {media_total}");
    Console.WriteLine($"Percentual de atletas aprovados: {percentual_aprovados}%");
    Console.WriteLine("---------------------------------");
    Console.ReadKey();
    
}

