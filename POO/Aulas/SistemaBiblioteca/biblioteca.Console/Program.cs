Tela tela = new Tela(80,25);
LivroCRUD livroCRUD = new LivroCRUD();

string opcao;
List<string> opcoes = new List<string>();
opcoes.Add("1 - Emprestimos");
opcoes.Add("2 - Livros     ");
opcoes.Add("3 - Alunos     ");
opcoes.Add("0 - Sair       ");

while (true)
{
    tela.PrepararTela("Sistema de Biblioteca");
    opcao = tela.MostrarMenu(opcoes, 2, 2);
    Console.ReadKey();

    switch (opcao)
    {
        case "1":
            break;
        case "2":
            livroCRUD.ExecutarCRUD();
            break;
        case "3":
            break;
        case "0":
            break;
    }

}
