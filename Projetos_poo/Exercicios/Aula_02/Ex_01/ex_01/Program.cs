using System;

const int max_livros = 50;
int qtd_livros_estoque = 0;
string nome_livro = "";
int qtd_livro = 0;
decimal preco_livro = 0;
string sair = "";
string[] nome_livros_inseridos = new string[50];
int[] qtd_livros_inseridos = new int[50];
decimal[] preco_livros_inseridos = new decimal[50];
decimal[] preco_total_livros_inseridos = new decimal[50];
int livro = 0;
decimal valor_total = 0;
int qtd_total_livros = 0;
string confirmar_livro = "";

Console.WriteLine("Olá, bem-vindo ao Sistema de Controle de Estoque de Livros!");
Console.WriteLine("--------");
Console.WriteLine("Aperte qualquer tecla para inserir um livro! \n");

Console.ReadKey();

Console.WriteLine("--------");


inserir_livros(nome_livro, qtd_livro, preco_livro, sair, confirmar_livro, nome_livros_inseridos, qtd_livros_inseridos, preco_livros_inseridos, livro, valor_total, preco_total_livros_inseridos, qtd_total_livros);

Console.Clear();
//entrada
static void inserir_livros(string nome_livro, int qtd_livro, decimal preco_livro, string sair, string confirmar_livro, string[] nome_livros_inseridos, int[] qtd_livros_inseridos, decimal[] preco_livros_inseridos, int livro, decimal valor_total, decimal[] preco_total_livros_inseridos, int qtd_total_livros)
{
    Console.Clear();
    while (sair != "sair")
    {
        while (confirmar_livro != "sim")
        {
            Console.WriteLine("Digite o nome do livro a ser inserido:");
            nome_livro = Console.ReadLine();

            Console.WriteLine($"Digite a quantidade do livro [{nome_livro}] que irá ao estoque:");
            qtd_livro = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o preço do livro: {nome_livro}");
            preco_livro = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Confirme o livro inserido");
            Console.WriteLine("/----------------------------/");

            Console.Write($"Título: {nome_livro}    ");
            Console.Write("|");
            Console.Write($"    Quantidade em estoque: {qtd_livro}  ");
            Console.Write("|");
            Console.Write($"    Preço unitário: {preco_livro}   ");
            Console.WriteLine("|");

            Console.WriteLine("\n Para confirmar digite 'sim', digite qualquer outra coisa para digitar novamente.");

            Console.WriteLine("/----------------------------/");

            confirmar_livro = Console.ReadLine();
        }
        if (validacao_livro(nome_livro, qtd_livro, preco_livro, confirmar_livro))
        {
            livro++;
            valor_total += preco_livro *  qtd_livro;
            qtd_total_livros += qtd_livro;
            nome_livros_inseridos[livro] = nome_livro;
            qtd_livros_inseridos[livro] = qtd_livro;
            preco_livros_inseridos[livro] = preco_livro;

            calculos_livros(qtd_livro, preco_livro, qtd_livros_inseridos, preco_livros_inseridos, livro, valor_total, preco_total_livros_inseridos);
            mostrar_livros(nome_livro, qtd_livro, preco_livro, sair, confirmar_livro, nome_livros_inseridos, qtd_livros_inseridos, preco_livros_inseridos, livro, valor_total, preco_total_livros_inseridos, qtd_total_livros);
        }
        confirmar_livro = "";
    }
}

//validação
static bool validacao_livro(string nome_livro, int qtd_livro, decimal preco_livro, string confirmar_livro)
{
    Console.Clear();
    if (nome_livro == "")
    {
        Console.WriteLine("Erro, digite novamente: O nome do livro deve conter pelo menos 1 caractere!");
        confirmar_livro = "erro";
        return false;
    }
    if (qtd_livro < 0)
    {
        Console.WriteLine("Erro, digite novamente: O livro não pode conter uma quantidade negativa em estoque!");
        confirmar_livro = "erro";
        return false;
    }
    if (preco_livro < 10 || preco_livro > 500)
    {
        Console.WriteLine("Erro, digite novamente: O livro está fora dos limites do preço unitário mínimo (10 reais) ou máximo (500 reais)!");
        confirmar_livro = "erro";
        return false;
    }
    return true;
}


//calculos
static void calculos_livros(int qtd_livro, decimal preco_livro, int[] qtd_livros_inseridos, decimal[] preco_livros_inseridos, int livro, decimal valor_total, decimal[] preco_total_livros_inseridos)
{
    preco_total_livros_inseridos[livro] = preco_livro * qtd_livro;
    valor_total += preco_livros_inseridos[livro];
}

//relatório
static void mostrar_livros(string nome_livro, int qtd_livro, decimal preco_livro, string sair, string confirmar_livro, string[] nome_livros_inseridos, int[] qtd_livros_inseridos, decimal[] preco_livros_inseridos, int livro, decimal valor_total, decimal[] preco_total_livros_inseridos, int qtd_total_livros)
{
    Console.Clear();
    //mostrando livros inseridos até agora
    Console.WriteLine("Os livros até agora inseridos foram");

    Console.WriteLine("/----------------------------/");
    for (int i = 1; i <= livro; i++)
    {
        Console.WriteLine($"Livro {i}:");

        Console.Write($"Nome: " + nome_livros_inseridos[i]);
        Console.Write("   |   ");
        Console.Write($"Quantidade: " + qtd_livros_inseridos[i]);
        Console.Write("   |   ");
        Console.Write($"Preço: " + preco_livros_inseridos[i]);
        Console.Write("   |   ");
        Console.Write($"Preço total do livro no estoque: " + preco_total_livros_inseridos[i]);
        Console.Write("   |   ");
        if (qtd_livros_inseridos[i] > 0)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Indisponível");
        }
    }
    Console.WriteLine("/----------------------------/");
    Console.WriteLine("==============// DADOS DO ESTOQUE //==============");

    Console.WriteLine($"Preço no estoque até agora: {valor_total}");
    Console.WriteLine($"Livros disponíveis no estoque: {qtd_total_livros}");

    Console.WriteLine("Para sair digite 'sair', para inserir um novo livro, aperte qualquer tecla.");
    sair = Console.ReadLine();
    if (sair == "sair")
    {
        return;
    }
}


