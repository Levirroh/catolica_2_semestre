public class LivroCRUD
{
    // propriedades
    private List<Livro> livros;
    private Livro livro;
    private int id;

    //sobrecarga de método permite que eu permite múltiplos métodos com o mesmo nome, porém com parâmetros diferentes. 
    //(Method Overload)

    // métodos
    public LivroCRUD()
    {
        //inicia a coleção de livros
        this.livros = new List<Livro>();
        //inicializa o obj para manipulação dos dados de UM livro
        this.livro = new Livro();
        //inicializa o ponteiro da coleção de lviros
        this.id = -1;
    }

    public void ExecutarCRUD()
    {
        //Montar tela do CRUD
        Tela tela = new Tela(46, 9, 15, 10);
        tela.PrepararTela("Cadastro de Livros");

        Console.ReadKey();
        //Escrever algoritmo do CRUD
    }


}