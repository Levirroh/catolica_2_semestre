using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AluguelCRUD
    {
        // atributos
        private List<AluguelDTO> listaAlugueis; // "Banco de dados"
        private AluguelDTO aluguel;             // Aluguel "da vez"
        private ClienteCRUD clienteCRUD;        // Para validar clientes
        private TemaCRUD temaCRUD;             // Para validar temas e atualizar disponibilidade
        private Tela tela;
        private int linha, coluna;              // Linha e coluna da tela para desenhar a moldura
        private int linhaEntrada, colunaEntrada; // Linha e coluna inicial para entrada de dados
        private int larguraTotal, larguraDados; // Largura total da tela e largura dos dados
        private List<string> campos;            // Lista de rótulos dos campos

        public AluguelCRUD(ClienteCRUD clienteCRUD, TemaCRUD temaCRUD)
        {
            this.listaAlugueis = new List<AluguelDTO>();
            this.aluguel = null;
            this.clienteCRUD = clienteCRUD;
            this.temaCRUD = temaCRUD;
            this.tela = new Tela();
            this.campos = new List<string> {
                "Código       :",
                "Cod. Cliente :",
                "Cod. Tema    :",
                "Data Festa   :",
                "Local Festa  :",
                "Hora Início  :",
                "Hora Fim     :",
                "Data Emprést.:",
                "Data Devolução:"
            };
            this.larguraTotal = 60; // Aumentado para acomodar nomes
            this.larguraDados = this.larguraTotal - this.campos[0].Length;
            this.coluna = 20;
            this.linha = 10;
        }

        private void entrarDados(int qual)
        {
            if (qual == 1)
            {
                // Entrada de código
                Console.SetCursorPosition(colunaEntrada, linhaEntrada);
                string entrada = Console.ReadLine();
                if (entrada.Length == 0)
                {
                    this.aluguel = null;
                    return;
                }
                this.aluguel = new AluguelDTO(
                    int.Parse(entrada),
                    new ClienteDTO(), // Placeholder
                    new TemaDTO(),    // Placeholder
                    DateTime.MinValue,
                    "",
                    "",
                    "",
                    DateTime.MinValue,
                    DateTime.MinValue
                );
            }
            else // qual == 2
            {
                // Limpar área dos campos (exceto código)
                this.tela.limparArea(colunaEntrada, linhaEntrada + 1, colunaEntrada + 45, linhaEntrada + campos.Count - 1);

                // Entrada para os demais campos
                for (int i = 1; i < campos.Count; i++)
                {
                    bool entradaValida = false;
                    while (!entradaValida)
                    {
                        Console.SetCursorPosition(colunaEntrada, linhaEntrada + i);
                        string entrada = Console.ReadLine();
                        try
                        {
                            switch (i)
                            {
                                case 1: // Cod. Cliente
                                    int codCliente = entrada.Length > 0 ? int.Parse(entrada) : 0;
                                    this.aluguel.Cliente = this.buscarCliente(codCliente);
                                    if (this.aluguel.Cliente != null)
                                    {
                                        // Exibir nome do cliente ao lado
                                        Console.SetCursorPosition(colunaEntrada + 10, linhaEntrada + i);
                                        Console.Write(this.aluguel.Cliente.Nome);
                                        entradaValida = true;
                                        this.tela.centralizar(""); // Limpar rodapé
                                    }
                                    else
                                    {
                                        this.tela.centralizar("Código inválido!");
                                    }
                                    break;
                                case 2: // Cod. Tema
                                    int codTema = entrada.Length > 0 ? int.Parse(entrada) : 0;
                                    this.aluguel.Tema = this.buscarTema(codTema);
                                    if (this.aluguel.Tema != null)
                                    {
                                        // Exibir nome do tema ao lado
                                        Console.SetCursorPosition(colunaEntrada + 10, linhaEntrada + i);
                                        Console.Write(this.aluguel.Tema.Nome);
                                        entradaValida = true;
                                        this.tela.centralizar(""); // Limpar rodapé
                                    }
                                    else
                                    {
                                        this.tela.centralizar("Código inválido!");
                                    }
                                    break;
                                case 3: // Data Festa
                                    this.aluguel.DataFesta = entrada.Length > 0 ? DateTime.Parse(entrada) : DateTime.MinValue;
                                    entradaValida = true;
                                    break;
                                case 4: // Local Festa
                                    this.aluguel.LocalFesta = entrada;
                                    entradaValida = true;
                                    break;
                                case 5: // Hora Início
                                    this.aluguel.HoraInicio = entrada.Length > 0 ? entrada : "";
                                    entradaValida = true;
                                    break;
                                case 6: // Hora Fim
                                    this.aluguel.HoraEncerramento = entrada.Length > 0 ? entrada : "";
                                    entradaValida = true;
                                    break;
                                case 7: // Data Empréstimo
                                    this.aluguel.DataEmprestimo = entrada.Length > 0 ? DateTime.Parse(entrada) : DateTime.MinValue;
                                    entradaValida = true;
                                    break;
                                case 8: // Data Devolução
                                    this.aluguel.DataDevolucao = entrada.Length > 0 ? DateTime.Parse(entrada) : DateTime.MinValue;
                                    entradaValida = true;
                                    break;
                            }
                        }
                        catch (FormatException)
                        {
                            if (i <= 2) // Cliente ou Tema
                                this.tela.centralizar("Código inválido!");
                            else
                                entradaValida = true; // Erros em outros campos são tratados em RegistrarAluguel
                        }
                    }
                }
            }
        }

        private void montarTelaAluguel(int coluna, int linha)
        {
            int coluna2 = coluna + this.larguraTotal;
            int linha2 = linha + campos.Count;

            this.tela.desenharMoldura(coluna, linha, coluna2, linha2);
            linha++;
            this.tela.centralizar("Registrar Aluguéis", linha, coluna, coluna2);

            coluna++;
            linha++;
            this.colunaEntrada = coluna + 1 + campos[0].Length;
            this.linhaEntrada = linha;
            for (int i = 0; i < campos.Count; i++)
            {
                Console.SetCursorPosition(coluna, linha + i);
                Console.Write(campos[i]);
            }
        }

        private void montarTelaDevolucao(int coluna, int linha)
        {
            int coluna2 = coluna + this.larguraTotal;
            int linha2 = linha + campos.Count;

            this.tela.desenharMoldura(coluna, linha, coluna2, linha2);
            linha++;
            this.tela.centralizar("Registrar Devolução", linha, coluna, coluna2);

            coluna++;
            linha++;
            this.colunaEntrada = coluna + 1 + campos[0].Length;
            this.linhaEntrada = linha;
            Console.SetCursorPosition(coluna, linha);
            Console.Write(campos[0]); // Código
        }

        // Métodos não modificados (incluídos para contexto)
        public void RegistrarAluguel()
        {
            this.montarTelaAluguel(this.coluna, this.linha);
            this.aluguel = null;
            this.tela.centralizar("Deixe o campo vazio para sair.");
            this.entrarDados(1);
            if (this.aluguel == null || !this.aluguel.Codigo.HasValue) return;

            if (this.buscarCodigo(this.aluguel.Codigo.Value))
            {
                this.tela.centralizar("Código de aluguel já existe!");
                Console.ReadLine();
                return;
            }

            try
            {
                this.entrarDados(2);

                if (this.aluguel.Cliente == null)
                {
                    this.tela.centralizar("Cliente não encontrado!");
                    Console.ReadLine();
                    return;
                }

                if (this.aluguel.Tema == null)
                {
                    this.tela.centralizar("Tema não encontrado!");
                    Console.ReadLine();
                    return;
                }
                if (this.aluguel.Tema.Disponivel.ToLower() != "s")
                {
                    this.tela.centralizar("Tema não está disponível!");
                    Console.ReadLine();
                    return;
                }

                if (this.aluguel.DataEmprestimo > this.aluguel.DataDevolucao)
                {
                    this.tela.centralizar("Data de empréstimo não pode ser posterior à devolução!");
                    Console.ReadLine();
                    return;
                }

                this.tela.centralizar("Confirma cadastro (S/N) : ");
                string resp = Console.ReadLine();
                if (resp.ToLower() == "s")
                {
                    this.listaAlugueis.Add(this.aluguel);
                    this.aluguel.Tema.Disponivel = "N";
                    this.tela.centralizar("Aluguel registrado com sucesso!");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                this.tela.centralizar("Entrada inválida! Verifique os formatos.");
                Console.ReadLine();
            }
        }

        public void RegistrarDevolucao()
        {
            this.montarTelaDevolucao(this.coluna, this.linha);
            this.aluguel = null;
            this.tela.centralizar("Deixe o campo vazio para sair.");
            this.entrarDados(1);
            if (this.aluguel == null || !this.aluguel.Codigo.HasValue) return;

            try
            {
                int posicao = -1;
                AluguelDTO aluguelEncontrado = null;

                for (int i = 0; i < this.listaAlugueis.Count; i++)
                {
                    if (this.listaAlugueis[i].Codigo == this.aluguel.Codigo.Value)
                    {
                        posicao = i;
                        aluguelEncontrado = this.listaAlugueis[i];
                        break;
                    }
                }

                if (posicao == -1)
                {
                    this.tela.centralizar("Aluguel não encontrado!");
                    Console.ReadLine();
                    return;
                }

                this.mostrarDadosAluguel(aluguelEncontrado);

                this.tela.centralizar("Confirma devolução (S/N) : ");
                string resp = Console.ReadLine();
                if (resp.ToLower() == "s")
                {
                    aluguelEncontrado.DataDevolucao = DateTime.Now.Date;
                    aluguelEncontrado.Tema.Disponivel = "S";
                    this.tela.centralizar("Devolução registrada com sucesso!");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                this.tela.centralizar("Código inválido!");
                Console.ReadLine();
            }
        }

        private bool buscarCodigo(int codigo)
        {
            return this.listaAlugueis.Exists(a => a.Codigo == codigo);
        }

        private ClienteDTO buscarCliente(int codigo)
        {
            foreach (var cliente in this.clienteCRUD.ObterListaClientes())
            {
                if (cliente.Codigo == codigo)
                    return cliente;
            }
            return null;
        }

        private TemaDTO buscarTema(int codigo)
        {
            foreach (var tema in this.temaCRUD.ObterListaTemas())
            {
                if (tema.Codigo == codigo)
                    return tema;
            }
            return null;
        }

        private void mostrarDadosAluguel(AluguelDTO aluguel)
        {
            this.tela.limparArea(colunaEntrada, linhaEntrada + 1, colunaEntrada + 45, linhaEntrada + campos.Count - 1);
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 1);
            Console.Write(aluguel.Cliente.Codigo);
            Console.SetCursorPosition(colunaEntrada + 10, linhaEntrada + 1);
            Console.Write(aluguel.Cliente.Nome);
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 2);
            Console.Write(aluguel.Tema.Codigo);
            Console.SetCursorPosition(colunaEntrada + 10, linhaEntrada + 2);
            Console.Write(aluguel.Tema.Nome);
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 3);
            Console.Write(aluguel.DataFesta.ToString("dd/MM/yyyy"));
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 4);
            Console.Write(aluguel.LocalFesta);
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 5);
            Console.Write(aluguel.HoraInicio);
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 6);
            Console.Write(aluguel.HoraEncerramento);
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 7);
            Console.Write(aluguel.DataEmprestimo.ToString("dd/MM/yyyy"));
            Console.SetCursorPosition(colunaEntrada, linhaEntrada + 8);
            Console.Write(aluguel.DataDevolucao.ToString("dd/MM/yyyy"));
        }

        public List<AluguelDTO> GetListaAlugueis()
        {
            return this.listaAlugueis;
        }


        public void MostrarRelatorio()
        {
            // Montar a tela
            this.montarTelaRelatorio(1, 5);

            // Selecionar tipo de relatório
            this.tela.centralizar("Mostrar aluguéis Ativos/Finalizados (A/F) : ");
            string tipo = Console.ReadLine().ToLower();
            if (tipo != "a" && tipo != "f")
            {
                this.tela.centralizar("Opção inválida!");
                Console.ReadLine();
                return;
            }

            // Filtrar aluguéis
            var hoje = DateTime.Now.Date;
            var alugueisFiltrados = tipo == "a"
                ? this.listaAlugueis.FindAll(a => a.DataDevolucao >= hoje)
                : this.listaAlugueis.FindAll(a => a.DataDevolucao < hoje);

            // Exibir relatório
            this.tela.limparArea(colunaEntrada, linhaEntrada, colunaEntrada + 50, linhaEntrada + 10);
            int linhaAtual = linhaEntrada;
            Console.SetCursorPosition(colunaEntrada, linhaAtual);
            Console.WriteLine($"{"Código",-8} {"Cliente",-20} {"Tema",-20} {"Data Festa",-12} {"Valor",10}");
            linhaAtual++;

            foreach (var aluguel in alugueisFiltrados)
            {
                Console.SetCursorPosition(colunaEntrada, linhaAtual);
                Console.WriteLine(
                    $"{aluguel.Codigo,-8} " +
                    $"{aluguel.Cliente.Nome,-20} " +
                    $"{aluguel.Tema.Nome,-20} " +
                    $"{aluguel.DataFesta:dd/MM/yyyy,-12} " +
                    $"{aluguel.ValorAluguel:F2,10}"
                );
                linhaAtual++;
            }

            if (alugueisFiltrados.Count == 0)
            {
                this.tela.centralizar("Nenhum aluguel encontrado!");
            }

            this.tela.centralizar("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }


        private void montarTelaRelatorio(int coluna, int linha)
        {
            int coluna2 = coluna + 70; // Maior para suportar a tabela
            int linha2 = linha + 12;   // Espaço para até 10 aluguéis

            this.tela.desenharMoldura(coluna, linha, coluna2, linha2);
            linha++;
            this.tela.centralizar("Relatório de Aluguéis", linha, coluna, coluna2);

            coluna++;
            linha++;
            this.colunaEntrada = coluna;
            this.linhaEntrada = linha;
        }

    }

