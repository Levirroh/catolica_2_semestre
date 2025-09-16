public class LivroCRUD
{
    // propriedades
    private List<Livro> livros;
    private Livro livro;
    private int id;
    private List<string> dados = new List<string>();
    private int larguraDados;
    private int colunaDados;
    private int linhaDados;

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

        //inicializa o vetor com as perguntas de livro 
        this.dados.Add("ISBN   : ");
        this.dados.Add("Título : ");
        this.dados.Add("Autor  : ");
        this.dados.Add("Ano    : ");
        this.dados.Add("Páginas: ");
    }

    public void ExecutarCRUD()
    {
        //Montar tela do CRUD
        Tela tela = new Tela(46, 9, 15, 5);
        tela.PrepararTela("Cadastro de Livros");
        tela.MontarTela(dados, 16, 7);

        //calcula a área dos dados
        this.larguraDados = 44 - dados[0].Length;
        this.colunaDados = 16 + dados[0].Length;
        this.linhaDados = 7;

        //CRUD
        this.EntrarCodigo();


        Console.ReadKey();
    }

    public void EntrarCodigo()
    {
        Console.SetCursorPosition(this.colunaDados, this.linhaDados);
        this.livro.isbn = Console.ReadLine();

    }

}