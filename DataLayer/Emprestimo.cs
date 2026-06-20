using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Emprestimo
    {
        public int IdEmprestimo { get; set; }
        public int IdLivro { get; set; }
        public int IdSocio { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public string Estado { get; set; }

        public string NomeSocio { get; set; }
        public string TituloLivro { get; set; }

    }
}
