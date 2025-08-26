public class Livro
{
    //propriedades
    public string? titulo;
    public string? autor;
    public string? isbn;
    public int anoPublicacao;
    public int nPagina;

    //métodos
    public Livro(string cod, string tit, string aut, int anoPub, int nPag)
    {
        isbn = cod;
        titulo = tit;
        autor = aut;
        anoPublicacao = anoPub;
        nPagina = nPag;
    }


    public void ImprimirDados()
    {
        Console.WriteLine($"ISBN        :   {isbn}");
        Console.WriteLine($"Título      :   {titulo}");
        Console.WriteLine($"Autor       :   {autor}");
        Console.WriteLine($"Ano Pub.    :   {anoPublicacao}");
        Console.WriteLine($"Nº páginas  :   {nPagina}");
    }


}