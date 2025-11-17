using System;

    public class AluguelDTO
    {
        public int? Codigo { get; set; }
        public ClienteDTO Cliente { get; set; }
        public TemaDTO Tema { get; set; }
        public DateTime DataFesta { get; set; }
        public string LocalFesta { get; set; }
        public string HoraInicio { get; set; }
        public string HoraEncerramento { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public double ValorAluguel { get; private set; }

        public AluguelDTO(
            int codigo,
            ClienteDTO cliente,
            TemaDTO tema,
            DateTime dataFesta,
            string localFesta,
            string horaInicio,
            string horaEncerramento,
            DateTime dataEmprestimo,
            DateTime dataDevolucao)
        {
            Codigo = codigo;
            Cliente = cliente;
            Tema = tema;
            DataFesta = dataFesta;
            LocalFesta = localFesta;
            HoraInicio = horaInicio;
            HoraEncerramento = horaEncerramento;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            ValorAluguel = CalcularValorAluguel();
        }

        private double CalcularValorAluguel()
        {
            TimeSpan diferenca = DataDevolucao - DataEmprestimo;
            int dias = diferenca.Days;
            if (dias < 1)
                dias = 1;
            return dias * Tema.Valor;
        }
    }

