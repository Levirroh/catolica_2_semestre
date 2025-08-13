
using System;

const int max_atletas = 20;
int atleta = 0;
string[][] pontuacoes_atletas = new string[max_atletas][5];//nome, pt1,pt2,pt3,media.
decimal media_total = 0;  
string sair = "";

Console.WriteLine("Olá, bem-vindo ao Sistema de Avaliação de Atletas!");
Console.WriteLine("--------");
Console.WriteLine("Aperte qualquer tecla para começar a preencher os dados da competição! \n");

Console.ReadKey();

Console.WriteLine("--------");


entrada_de_dados(max_atletas, pontuacoes_atletas, media_total, sair, atleta);

Console.Clear();

//entrada
static void entrada_de_dados(int max_atletas, string[][]pontuacoes_atletas, decimal media_total, string sair, int atleta)
{
    Console.Clear();
    while (sair != "2" && atleta <= 20)
    {
        atleta++;
        Console.WriteLine($"Digite o nome do {i}º atleta");
        pontuacoes_atletas[atleta][0] = Console.ReadLine();

        Console.WriteLine($"Digite a 1ª pontuação do {i}º atleta");
        pontuacoes_atletas[atleta][1] = Console.ReadLine();

        Console.WriteLine($"Digite a 2ª pontuação do {i}º atleta");
        pontuacoes_atletas[atleta][2] = Console.ReadLine();

        Console.WriteLine($"Digite a 3ª pontuação do {i}º atleta");
        pontuacoes_atletas[atleta][3] = Console.ReadLine();

        Console.WriteLine("Deseja finalizar a inserção de dados? Digite [1] para sair");
        sair = Console.ReadLine();
    }

    calculo_de_medias(pontuacoes_atletas, atleta);

    calculo_de_medias();

    calculo_de_medias();
}

static void calculo_de_medias(string[][] pontuacoes_atletas, int atleta)
{
    for (int i = 0; i < atleta; i++)
    {
        for (int j = 1; j < 4; j++)
        {
            pontuacoes_atletas[i][4] += int.Parse(pontuacoes_atletas[i][j]);
        }
        media_total += int.Parse(pontuacoes_atletas[i][4]);
    }
    verificacao_de_classificacao(pontuacoes_atletas);
}

static void verificacao_de_classificacao(string[][] pontuacoes_atletas)
{
}

static void geracao_de_relatorio()
{
}

