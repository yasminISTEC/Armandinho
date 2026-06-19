using System;
using DataLayer;

namespace BusinessLayer
{
    public class LivrosBusiness
    {
        private LivrosData _livrosData = new LivrosData();

        //validar livro

        public string ValidarLivro(Livro livro)
        {
            if (string.IsNullOrWhiteSpace(livro.ISBN))
                return "O ISBN 'e obrigatorio";

            if (livro.ISBN.Length > 20)
                return "O ISBN nao pode ter mais de 20 caracteres";

            if (string.IsNullOrWhiteSpace(livro.Titulo))
                return "O Titulo 'e obrigatorio";

            if (string.IsNullOrEmpty(livro.Autor))
                return "O Autor 'e obrigatorio";

            if (livro.AnoPublicacao.HasValue)
            {
                if (livro.AnoPublicacao < 1000 || livro.AnoPublicacao > DateTime.Now.Year)
                    return $"O ano deve ser entre 1000 e {DateTime.Now.Year}";

                if (livro.ExemplaresDisponiveis < 0)
                    return "Os exemplares nao podem ser negativos";
            }
            return null;
        }

        //inserir com vaidacoes

        public string InserirLivro(Livro livro)
        {
            string erro = ValidarLivro(livro);
            if (erro != null)
                return erro;
            
            _livrosData.InserirLivro(livro);
            return null;  

        }

        //ediar com validacaoes

        public string EditarLivro(Livro livro)
        {
            string erro = ValidarLivro(livro);
            if (erro != null) return erro;

            _livrosData.EditarLivro(livro);
            return null;
        }

        //eleminar

        public void EliminarLivro(int idLivro) 
        {
            _livrosData.EliminarLivro(idLivro);
        }

        //pesquisar

        public List<Livro> PesquisarLivros(string texto)
        { 
            if (string.IsNullOrEmpty(texto))
                return _livrosData.ListarLivros();

            return _livrosData.PesquisarLivros(texto);
        }
    }






}

