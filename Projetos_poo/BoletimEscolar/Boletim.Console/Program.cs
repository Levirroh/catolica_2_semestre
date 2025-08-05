// quantidade de registros

using System.Data;

int qtd = 3;

// variaveis de entrada
int idade;
string? nome;

// vetores para armazenamento dos registros
int[] idades = new int[qtd];
string[] nomes = new string[qtd];


// seção de cadastro de alunos
for (int i = 0; i <= qtd; i++)
{
    Console.Clear();
    Console.WriteLine($"Cadastrando registro Nº {i + 1}");
    Console.WriteLine("Nome  : ");
    nome = Console.ReadLine();

    Console.WriteLine("Idade : ");
    idade = int.Parse(Console.ReadLine() ?? "0"); // cast: trocando o tipo do valor
    nomes[i] = nome ?? "Sem nome";
    idades[i] = idade;
    Console.ReadKey();
}

//seção de listagem
Console.WriteLine("Listagem de alunos");
Console.WriteLine("------------------");

for (int i = 0; i <= qtd; i++)
{
    Console.WriteLine($"Mostrando registro Nº {i + 1}:");
    Console.WriteLine($"Nome  : {nomes[i]} \t|\t {idades[i]}");
    Console.WriteLine("------------------");
}
Console.WriteLine("Pressione para finalizar");
Console.ReadKey();