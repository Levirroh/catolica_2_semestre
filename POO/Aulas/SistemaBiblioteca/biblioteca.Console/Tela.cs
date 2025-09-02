public class Tela
{
    //propriedades
    private int largura;
    private int altura;

    //métodos
    public Tela(int lar, int alt)
    {
        this.largura = lar;
        this.altura = alt;
    }

    public void PrepararTela()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        this.MontarMoldura(0, 0, this.largura, this.altura);
        this.Centralizar(0, this.largura, 1, "sistema de Biblioteca");
    }

    public void Centralizar(int ci, int cf, int lin, string msg)
    {
        int col = (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(col, lin);
        Console.Write(msg);
    }

    public void MontarMoldura(int ci, int li, int cf, int lf)
    {
        int col, lin;
        //linhas horizontais
        for (col = ci; col < cf; col++)
        {

            //linha horizontal superior
            Console.SetCursorPosition(col, li);
            Console.Write("═");
            //linha horizontal inferior
            Console.SetCursorPosition(col, cf);
            Console.Write("═");

        }
        for (lin = li; lin < lf; lin++)
        {
            //linha vertical superior
            Console.SetCursorPosition(ci, lin);
            Console.Write("║");
            //linha vertical inferior
            Console.SetCursorPosition(cf, lin);
            Console.Write("║");
        }
        //desenha os cantos
        Console.SetCursorPosition(ci, lin);
        Console.Write("╔");

        Console.SetCursorPosition(cf, lf);
        Console.Write("╗");

        Console.SetCursorPosition(ci, lin);
        Console.Write("╚");

        Console.SetCursorPosition(cf, lin);
        Console.Write("╝");
    }

    public string MostrarMenu(List<string> ops, int ci, int li)
    {
        int cf, lf, linha;

        cf = ci + ops[0].Length + 1;
        lf = li + ops.Count + 2;
        this.MontarMoldura(ci, li, cf, lf);
        linha = li + 1;
        for (int i = 0; i < ops.Count; i++)
        {
            Console.SetCursorPosition(ci + 1, linha);
            Console.Write(ops[i]);
            linha++;
        }
        Console.SetCursorPosition(ci + 1, linha);
        Console.Write("Opcao: ");
        string op = Console.ReadLine();
        return op;
    }
}