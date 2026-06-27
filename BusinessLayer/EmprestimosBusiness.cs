using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
namespace BusinessLayer
{
    public class EmprestimosBusiness
    {
        private EmprestimosData _emprestimosData = new EmprestimosData();

        private LivrosData _livrosData = new LivrosData();

        //validar emprestimo

        public string ValidarEmprestimo(Emprestimo emprestimo)
        {
            if (emprestimo.IdLivro <= 0)
                return "Tem de selecionar um livro";

            if (emprestimo.IdSocio <= 0)
                return "Tem de selecionar um socio";

            List<Livro> livros = _livrosData.ListarLivros();
            Livro livro = livros.Find(l => l.IdLivro == emprestimo.IdLivro);

            if (livro == null)
                return "Livro nao encontrado";

            if (livro.ExemplaresDisponiveis <=0)
                return $"O livro '{livro.Titulo}' não tem exemplares disponíveis.";

            return null;
        }

        //registar emprestimo

        public string RegistarEmprestimo(int idLivro, int idSocio, int prazoDias)
        {
            Emprestimo emprestimo = new Emprestimo
            {
                IdLivro = idLivro,
                IdSocio = idSocio,
                DataEmprestimo = DateTime.Now,
                DataPrevistaDevolucao = DateTime.Now.AddDays(prazoDias),
                Estado = "Por Devolver"
            };

            string erro = ValidarEmprestimo(emprestimo);
            if (erro != null) return erro;

            _emprestimosData.RegistrarEmprestimo(emprestimo);
            return null;
        }

        //registrar devolucao

        public void RegistarDevolucao(int idEmprestimo, int idLivro) 
        {
            _emprestimosData.RegistrarDevolucao(idEmprestimo, idLivro);
        }

        //eliminar 
        public void EliminarEmprestimo(int idEmprestimo)
        {
            _emprestimosData.EliminarEmprestimo(idEmprestimo);
        }

        // =============================================
        // LISTAR TODOS
        // =============================================
        public List<Emprestimo> ListarEmprestimos()
        {
            return _emprestimosData.ListarEmprestimo();
        }

        // =============================================
        // LISTAR EM ABERTO
        // =============================================
        public List<Emprestimo> ListarEmAberto()
        {
            return _emprestimosData.ListarEmAberto();
        }

        // =============================================
        // CALCULAR MULTA
        // =============================================
        public decimal CalcularMulta(Emprestimo emprestimo, decimal valorMultaPorDia)
        {
            if (emprestimo.DataDevolucao == null)
            {
                // ainda não devolvido — calcula até hoje
                if (DateTime.Now > emprestimo.DataPrevistaDevolucao)
                {
                    int dias = (DateTime.Now - emprestimo.DataPrevistaDevolucao).Days;
                    return dias * valorMultaPorDia;
                }
            }
            else
            {
                // já devolvido — calcula até à data de devolução
                if (emprestimo.DataDevolucao > emprestimo.DataPrevistaDevolucao)
                {
                    int dias = (emprestimo.DataDevolucao.Value - emprestimo.DataPrevistaDevolucao).Days;
                    return dias * valorMultaPorDia;
                }
            }
            return 0;
        }
    }
}




 

