using System;
using System.Collections.Generic;

public class TemaCRUD : BaseCRUD<TemaDTO>
{

    protected override void InicializarCampos()
    {
        this.campos.AddRange(new[] { "Código    :", "Nome      :", "Categoria :", "Disponível:", "Valor     :" });
        this.larguraDados = this.larguraTotal - this.campos[0].Length;
    }

    protected override void MontarTela(int coluna, int linha)
    {
        // Definir dimensões da moldura
        int coluna2 = coluna + this.larguraTotal;
        int linha2 = linha + this.campos.Count + 2; // +2 para título e borda

        // Desenhar moldura
        this.tela.desenharMoldura(coluna, linha, coluna2, linha2);

        // Exibir título
        linha++;
        this.tela.centralizar("Cadastro de Tema", linha, coluna, coluna2);

        // Exibir rótulos dos campos
        coluna++;
        linha++;
        this.colunaEntrada = coluna + 1 + this.campos[0].Length; // Define posição para entrada de dados
        this.linhaEntrada = linha; // Define linha inicial para entrada de dados
        for (int i = 0; i < this.campos.Count; i++)
        {
            Console.SetCursorPosition(coluna, linha + i);
            Console.Write(this.campos[i]);
        }
    }

    protected override void EntrarDados(int qual)
    {
        string entrada;
        if (qual == 1)
        {
            Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada);
            entrada = Console.ReadLine();
            if (entrada.Length > 0)
            {
                ((TemaDTO)this.registro).Codigo = int.Parse(entrada);
            }
            else
            {
                this.registro = new TemaDTO(); // Registro vazio para sair
            }
        }
        else // qual == 2
        {
            this.tela.limparArea(this.colunaEntrada, this.linhaEntrada + 1, this.colunaEntrada + 25, this.linhaEntrada + 4);
            for (int i = 1; i < this.campos.Count; i++)
            {
                Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + i);
                entrada = Console.ReadLine();
                switch (i)
                {
                    case 1: ((TemaDTO)this.registro).Nome = entrada; break;
                    case 2: ((TemaDTO)this.registro).Categoria = entrada; break;
                    case 3: ((TemaDTO)this.registro).Disponivel = entrada; break;
                    case 4: ((TemaDTO)this.registro).Valor = entrada.Length > 0 ? double.Parse(entrada) : 0.0; break;
                }
            }
        }
    }

    protected override void MostrarDados()
    {
        var tema = (TemaDTO)this.lista[this.posicao];
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 1);
        Console.Write(tema.Nome);
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 2);
        Console.Write(tema.Categoria);
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 3);
        Console.Write(tema.Disponivel);
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 4);
        Console.Write(tema.Valor.ToString("F2"));
    }

    protected override void AlterarRegistro()
    {
        var tema = (TemaDTO)this.registro;
        var temaExistente = (TemaDTO)this.lista[this.posicao];
        if (tema.Nome != "") temaExistente.Nome = tema.Nome;
        if (tema.Categoria != "") temaExistente.Categoria = tema.Categoria;
        if (tema.Disponivel != "") temaExistente.Disponivel = tema.Disponivel;
        if (tema.Valor != 0.0) temaExistente.Valor = tema.Valor;
    }

    protected override int? GetCodigo(TemaDTO registro)
    {
        return registro.Codigo;
    }

    // Método mantido para compatibilidade com AluguelCRUD
    public List<TemaDTO> ObterListaTemas()
    {
        return this.lista;
    }
}