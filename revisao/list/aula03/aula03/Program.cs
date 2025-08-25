using System.Reflection.PortableExecutable;
List<string> menu = List<string>();
menu.Add("1 - Cadastrar");
menu.Add("2 - Consultar");
menu.Add("3 - Alterar  ");
menu.Add("4 - Excluir  ");
menu.Add("0 - Sair     ");
//menu.RemoveAt(0); // para excluir uma opcao

while (true)
{
    Console.Clear();

    string op = MostrarMenu(menu, 10, 2);// mostrando o menu a partir da col x li y.

    if (op == "0") break;
    if (op == "1")
        MostrarMensagem("Você escolheu cadastrar");
    if (op == "2")
        MostrarMensagem("Você escolheu consultar");
    if (op == "3")
        MostrarMensagem("Você escolheu excluir");
    if (op == "4")
        MostrarMensagem("Você escolheu sair");
}


string MostrarMenu(List<string> ops, int ci, int li)
{

    //calcula as coordenadas de início e fim
    int cf = ci + ops[0].Length; // coluna inicial e final 
    int lf = li + ops.Count + 1;  // linha inicial e final

    //pede para montar uma moldura
    MontarMoldura(ci, li, cf, lf);

    int lin = li + 1;
    int col = ci + 1;

    //coloca as opções dentro da moldura
    for (int i = 0; i < ops.Count; i++)
    {
        Console.SetCursorPosition(col, lin);
        Console.Write(ops[i]);
        lin++;
    }

    Console.ReadKey();


    return "";
}


string MostrarMensagem(string msn){
    Console.SetCursorPosition(0, 0);
    Console.Write(msn);
    return msn;
}

void MontarMoldura(int ci, int li, int cf, int lf)
{
    //desenha as linhas vertical
    for (int lin = li; lin <= lf; lin++)
    {
        // desenha a linha vertical esquerda
        Console.SetCursorPosition(ci, lin);
        Console.Write("|");


        //desenha a linha vertical direita
        Console.SetCursorPosition(cf, lin);
        Console.Write("|");
    }

    //desenha as linhas horizontais
    for (int col = ci; col <= cf; col++)
    {
        // desenha a linha horizontal superior
        Console.SetCursorPosition(col, li);
        Console.Write("_");

        // desenha a linha horizontal inferior
        Console.SetCursorPosition(col, lf);
        Console.Write("_");
    }
}