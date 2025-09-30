public class LivroCRUD
{
    // propriedades
    private List<Livro> livros;
    private Livro livro;
    private int posicao;
    private List<string> dados = new List<string>();
    private int larguraDados;
    private int colunaDados;
    private int linhaDados;
    private Tela tela;

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
        this.posicao = -1;

        //inicializa o vetor com as perguntas de livro 
        this.dados.Add("ISBN   : ");
        this.dados.Add("Título : ");
        this.dados.Add("Autor  : ");
        this.dados.Add("Ano    : ");
        this.dados.Add("Páginas: ");

        //inicializa um obj do tipo tela
        this.tela = new Tela(46, 9, 15, 5);
    }

    public void ExecutarCRUD()
    {
        string resp; 
        //Montar tela do CRUD
        this.tela.PrepararTela("Cadastro de Livros");
        this.tela.MontarTela(dados, 16, 7);

        //calcula a área dos dados
        this.larguraDados = 44 - dados[0].Length;
        this.colunaDados = 16 + dados[0].Length;
        this.linhaDados = 7;

        //CRUD
        this.EntrarDados(1);
        bool achou = this.ProcurarCodigo();


        if (!achou)
        {
            this.tela.MostrarMensagem(this.colunaDados, this.linhaDados + 5, "ISBN não encontrado");
            resp = tela.Perguntar(this.colunaDados, this.linhaDados + 6, "Deseja cadastrar este livro? (S/N) : ");

            #region  Cadastrando Livro
            if (resp.ToLower() == "s")
            {
                this.EntrarDados(2);
                resp = this.tela.Perguntar(this.colunaDados, this.linhaDados + 6, "Confirma o cadastro do livro? (S/N) :");
                if (resp.ToLower() == "s")
                {
                    this.livros.Add(
                        new Livro(this.livro.isbn, this.livro.titulo, this.livro.autor, this.livro.anoPublicacao, this.livro.paginas)
                    );
                }
            }
            #endregion
        }
        else
        {
            this.MostrarDados();
            Console.ReadKey();
        }

        Console.ReadKey();
    }

    public void EntrarDados(int qual)
    {
        if (qual == 1)
        {
            Console.SetCursorPosition(this.colunaDados, this.linhaDados);
            this.livro.isbn = Console.ReadLine();
        }
        else
        {
            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 1);
            this.livro.titulo = Console.ReadLine();

            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 2);
            this.livro.autor = Console.ReadLine();

            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 3);
            this.livro.anoPublicacao = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(this.colunaDados, this.linhaDados + 4);
            this.livro.paginas = int.Parse(Console.ReadLine());

        }

    }

    public bool ProcurarCodigo()
    {
        bool encontrei = false;

        for (int i = 0; i < this.livros.Count; i++)
        {
            if (this.livro.isbn == this.livros[i].isbn)
            {
                encontrei = true;
                this.posicao = i;
                break;
            }
        }
        return encontrei;
    }
    public void MostrarDados()
    {
        this.tela.MostrarMensagem(
            this.colunaDados,
            this.linhaDados + 1,
            this.livros[this.posicao].titulo
        );
        this.tela.MostrarMensagem(this.colunaDados,
            this.linhaDados + 2,
            this.livros[this.posicao].autor
        );
        this.tela.MostrarMensagem(this.colunaDados,
            this.linhaDados + 3,
            this.livros[this.posicao].anoPublicacao.ToString()
        );
        this.tela.MostrarMensagem(this.colunaDados,
            this.linhaDados + 4,
            this.livros[this.posicao].paginas.ToString()
        );
    }
}