Tela tela = new Tela(80, 25);

string opcao;
List<string> opcoes = new List<string>();
opcoes.Add("1 - Emprestimos");
opcoes.Add("2 - Livros");
opcoes.Add("3 - Alunos");
opcoes.Add("4 - Sair");

while (true)
{
    tela.PrepararTela();
    tela.MostrarMenu(opcoes, 3, 3);
    Console.ReadKey();
    
}


Console.WriteLine("---=== Sistema de Biblioteca ===---");



