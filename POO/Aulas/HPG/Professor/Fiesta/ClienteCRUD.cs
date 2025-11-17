using System;
using System.Collections.Generic;

public class ClienteCRUD : BaseCRUD<ClienteDTO>
{

    protected override void InicializarCampos()
    {
        this.campos.AddRange(new[] { "Código   :", "Nome     :", "Email    :", "Telefone :" });
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
        this.tela.centralizar("Cadastro de Cliente", linha, coluna, coluna2);

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
                ((ClienteDTO)this.registro).Codigo = int.Parse(entrada);
            }
            else
            {
                this.registro = new ClienteDTO(); // Registro vazio para sair
            }
        }
        else // qual == 2
        {
            this.tela.limparArea(this.colunaEntrada, this.linhaEntrada + 1, this.colunaEntrada + 25, this.linhaEntrada + 3);
            for (int i = 1; i < this.campos.Count; i++)
            {
                Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + i);
                entrada = Console.ReadLine();
                switch (i)
                {
                    case 1: ((ClienteDTO)this.registro).Nome = entrada; break;
                    case 2: ((ClienteDTO)this.registro).Email = entrada; break;
                    case 3: ((ClienteDTO)this.registro).Telefone = entrada; break;
                }
            }
        }
    }

    protected override void MostrarDados()
    {
        var cliente = (ClienteDTO)this.lista[this.posicao];
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 1);
        Console.Write(cliente.Nome);
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 2);
        Console.Write(cliente.Email);
        Console.SetCursorPosition(this.colunaEntrada, this.linhaEntrada + 3);
        Console.Write(cliente.Telefone);
    }

    protected override void AlterarRegistro()
    {
        var cliente = (ClienteDTO)this.registro;
        var clienteExistente = (ClienteDTO)this.lista[this.posicao];
        if (cliente.Nome != "") clienteExistente.Nome = cliente.Nome;
        if (cliente.Email != "") clienteExistente.Email = cliente.Email;
        if (cliente.Telefone != "") clienteExistente.Telefone = cliente.Telefone;
    }

    protected override int? GetCodigo(ClienteDTO registro)
    {
        return registro.Codigo;
    }

    // Método mantido para compatibilidade com AluguelCRUD
    public List<ClienteDTO> ObterListaClientes()
    {
        return this.lista;
    }
}