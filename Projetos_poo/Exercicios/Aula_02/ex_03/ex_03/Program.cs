const int max_produtos = 40;
int[,] pontuacoes_atletas = new int[max_atletas, 3];
string[] nomes_atletas = new string[max_atletas];
decimal[] media_atletas = new decimal[max_atletas];
string[] classificacoes_atletas = new string[max_atletas];

Console.WriteLine("Olá, bem-vindo ao Sistema de Avaliação de Atletas!");
Console.WriteLine("--------");
Console.WriteLine("Aperte qualquer tecla para começar a preencher os dados da competição! \n");

Console.ReadKey();

Console.WriteLine("--------");


entrada_de_dados();

calculo_de_medias();

verificacao_de_classificacao();

geracao_de_relatorio();

Console.Clear();

static int entrada_de_dados()
{
}

static decimal calculo_de_medias()
{
   
}

static void verificacao_de_classificacao()
{
    
}

static void geracao_de_relatorio(){

    
}

