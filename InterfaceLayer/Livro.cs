using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public int? AnoPublicaco { get; set; }

        public int ExemplaresDisponiveis { get; set; }
    }
}
