using System;
using System.Collections.Generic;

public abstract class BaseCRUD<T> where T : class, new()
{
    protected List<T> lista; // "Banco de dados"
    protected T registro; // Registro "da vez"
    protected Tela tela;
    protected int linha, coluna, linhaEntrada, colunaEntrada, larguraTotal, larguraDados, posicao;
    protected List<string> campos;

    public BaseCRUD()
    {
        this.lista = new List<T>();
        this.tela = new Tela();
        this.larguraTotal = 40; // Valor padrão
        this.larguraDados = 0;
        this.coluna = 20;
        this.linha = 10;
        this.campos = new List<string>();
        this.InicializarCampos();
    }

    protected abstract void InicializarCampos(); // Define os rótulos dos campos
    protected abstract void MontarTela(int coluna, int linha); // Monta a tela do CRUD
    protected abstract void EntrarDados(int qual); // Entrada de dados (código ou demais campos)
    protected abstract void MostrarDados(); // Exibe os dados do registro encontrado
    protected abstract void AlterarRegistro(); // Altera os dados do registro
    protected abstract int? GetCodigo(T registro); // Obtém o código do registro

    public void ExecutarCRUD()
    {
        while (true)
        {
            // 1 - Montar a tela do CRUD
            this.MontarTela(this.coluna, this.linha);

            // 2 - Preparar um registro em branco
            this.registro = new T();

            // 3 - Perguntar ao usuário o código
            this.tela.centralizar("Deixe o campo vazio para sair.");
            this.EntrarDados(1);
            if (this.registro == null || this.GetCodigo(this.registro) == 0) break;

            // 4 - Procurar pela chave no "banco de dados"
            bool achou = this.BuscarCodigo(this.GetCodigo(this.registro).Value);

            // 5 - Se não achou a chave
            if (!achou)
            {
                // 5.1 - Informar que não achou
                this.tela.centralizar("Registro não encontrado. Deseja cadastrar (S/N): ");

                // 5.2 - Perguntar se deseja cadastrar
                string resp = Console.ReadLine();

                // 5.3 - Se o usuário deseja cadastrar
                if (resp.ToLower() == "s")
                {
                    // 5.3.1 - Perguntar os dados restantes
                    this.EntrarDados(2);

                    // 5.3.2 - Confirmar cadastro
                    this.tela.centralizar("Confirma cadastro (S/N) : ");
                    resp = Console.ReadLine();

                    // 5.3.3 - Se confirmado, incluir o registro
                    if (resp.ToLower() == "s")
                    {
                        this.IncluirRegistro();
                    }
                }
            }
            // 6 - Se achou a chave
            else
            {
                // 6.1 - Mostrar os dados
                this.MostrarDados();

                // 6.2 - Perguntar se deseja voltar, alterar ou excluir
                this.tela.centralizar("Deseja Voltar/Alterar/Excluir (V/A/E) : ");
                string resp = Console.ReadLine();

                // 6.3 - Se deseja alterar
                if (resp.ToLower() == "a")
                {
                    // 6.3.1 - Perguntar novos dados
                    this.tela.centralizar("Digite apenas o dado que deseja alterar");
                    this.EntrarDados(2);

                    // 6.3.2 - Confirmar alteração
                    this.tela.centralizar("Confirma alteração (S/N) : ");
                    resp = Console.ReadLine();

                    // 6.3.3 - Se confirmado, alterar o registro
                    if (resp.ToLower() == "s")
                    {
                        this.AlterarRegistro();
                    }
                }

                // 6.4 - Se deseja excluir
                if (resp.ToLower() == "e")
                {
                    // 6.4.1 - Confirmar exclusão
                    this.tela.centralizar("Confirma exclusão (S/N) : ");
                    resp = Console.ReadLine();

                    // 6.4.2 - Se confirmado, excluir o registro
                    if (resp.ToLower() == "s")
                    {
                        this.ExcluirRegistro();
                    }
                }
            }
        }
    }

    protected bool BuscarCodigo(int codigo)
    {
        for (int i = 0; i < this.lista.Count; i++)
        {
            if (this.GetCodigo(this.lista[i]) == codigo)
            {
                this.posicao = i;
                return true;
            }
        }
        return false;
    }

    protected void IncluirRegistro()
    {
        this.lista.Add(this.registro);
    }

    protected void ExcluirRegistro()
    {
        this.lista.RemoveAt(this.posicao);
    }

    public List<T> ObterLista()
    {
        return this.lista;
    }
}