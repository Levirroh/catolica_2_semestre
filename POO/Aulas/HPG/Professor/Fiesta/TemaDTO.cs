public class TemaDTO
{
    // atributos
    private int? codigo;
    private string nome;
    private string categoria;
    private string disponivel;
    private double valor;

    // propriedades
    public int? Codigo { get => codigo; set => codigo = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Categoria { get => categoria; set => categoria = value; }
    public string Disponivel { get => disponivel; set => disponivel = value; }
    public double Valor { get => valor; set => valor = value; }

    public TemaDTO(int codigo, string nome, string categoria, string disponivel, double valor)
    {
        Codigo = codigo;
        Nome = nome;
        Categoria = categoria;
        Disponivel = disponivel;
        Valor = valor;
    }

    public TemaDTO()
    {
        Codigo = 0;
        Nome = "";
        Categoria = "";
        Disponivel = "";
        Valor = 0.0;
    }
}