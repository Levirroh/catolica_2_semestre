const int max_atletas = 20;
int atleta = 0;
int[,] pontuacoes_atletas = new int[max_atletas, 3];//pt1,pt2,pt3.
string[] nomes_atletas = new string[max_atletas];//nomes
decimal[] media_atletas = new decimal[max_atletas];//media.
decimal media_total = 0;  
string sair = "";

Console.WriteLine("Olá, bem-vindo ao Sistema de Avaliação de Atletas!");
Console.WriteLine("--------");
Console.WriteLine("Aperte qualquer tecla para começar a preencher os dados da competição! \n");

Console.ReadKey();

Console.WriteLine("--------");


entrada_de_dados(max_atletas, pontuacoes_atletas, sair, atleta, nomes_atletas, media_atletas, media_total);

Console.Clear();

//entrada
static void entrada_de_dados(int max_atletas, int[,]pontuacoes_atletas, string sair, int atleta, string[] nomes_atletas, decimal[] media_atletas, decimal media_total)
{
    Console.Clear();
    while (sair != "1" && atleta <= 20)
    {
        atleta++;
        Console.WriteLine($"Digite o nome do {atleta}º atleta");
        nomes_atletas[atleta] = Console.ReadLine();

        Console.WriteLine($"Digite a 1ª pontuação do {atleta}º atleta");
        pontuacoes_atletas[atleta, 0] = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a 2ª pontuação do {atleta}º atleta");
        pontuacoes_atletas[atleta, 1] = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a 3ª pontuação do {atleta}º atleta");
        pontuacoes_atletas[atleta, 2] = int.Parse(Console.ReadLine());

        Console.WriteLine("Deseja finalizar a inserção de dados? Digite [1] para sair");
        sair = Console.ReadLine();
    }
    calculo_de_medias(pontuacoes_atletas, atleta, media_total, media_atletas);
}

static void calculo_de_medias(int[,] pontuacoes_atletas, int atleta, decimal media_total, decimal[] media_atletas)
{
    for (int i = 0; i < atleta; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            media_atletas[i] += decimal.Parse(pontuacoes_atletas[i, j]);
            media_total += decimal.Parse(pontuacoes_atletas[i, j]);
        }
        media_atletas[i] = media_atletas[i] / 3;
    }

    media_total /= atleta;
    Console.WriteLine(media_total);
    Console.ReadKey();
    //verificacao_de_classificacao(pontuacoes_atletas);
}
/*
static void verificacao_de_classificacao(string[][] pontuacoes_atletas)
{

}

static void geracao_de_relatorio()
{
}

*/