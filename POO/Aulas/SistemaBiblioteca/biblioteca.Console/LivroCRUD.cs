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
        this.livros = new List<Livro>();
        this.livro = new Livro();
    }
}