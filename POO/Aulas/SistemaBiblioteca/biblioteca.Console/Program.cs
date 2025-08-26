Console.Clear();
Console.WriteLine("---=== Sistema de Biblioteca ===---");

//cria 2 objetos de livros

//tipos primitivos: int, string..

//tipos construídos
//podem ser construídos das seguintes formas:

//a mais recomendada
Livro livro1 = new Livro("123", "O Senhor dos Aneis", "JRR Tolkien", 2015, 1247); // obj livro1

Livro livro2 = new Livro("437", "Ilíada", "Homero", 2020, 421); // obj livro2

//Se não possuir constructor pode ser assim:
// Livro livro2 = new Livro("437"); // obj livro2
// //aqui foi instanciado ou criado uma instância da classe livro
// livro2.isbn = "437";
// livro2.titulo = "Ilíada";
// livro2.autor = "Homero";
// livro2.anoPublicacao = 2020;
// livro2.nPagina = 421;

//mostra na tela os dados do objeto livro1
Console.WriteLine("Dados do livro1: ");
livro1.ImprimirDados();

Console.WriteLine("\n ====----====----====----====---- \n");

Console.WriteLine("Dados do livro2: ");
livro2.ImprimirDados();

Console.WriteLine("====----====----====----====----");



