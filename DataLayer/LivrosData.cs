using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;


namespace DataLayer
{
    public class LivrosData
    {
        public List<Livro> ListarLivros()
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Livros";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    livros.Add(new Livro
                    {
                        IdLivro = (int)reader["IdLivro"],
                        ISBN = reader["ISBN"].ToString(),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        AnoPublicacao = reader["AnoPublicacao"] == DBNull.Value ? null : (int?)reader["AnoPublicacao"],
                        ExemplaresDisponiveis = (int)reader["ExemplaresDisponiveis"]
                    });
                }
            }
            return livros;
        }
        //inseir livros

        public void InserirLivro(Livro livro)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Livros (ISBN, Titulo, Autor, AnoPublicacao, ExemplaresDisponiveis) 
                    VALUES (@ISBN, @Titulo, @Autor, @AnoPublicacao, @ExemplaresDisponiveis)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);
                cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", livro.Autor);
                cmd.Parameters.AddWithValue("@AnoPublicacao", (object)livro.AnoPublicacao ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ExemplaresDisponiveis", livro.ExemplaresDisponiveis);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //editar livro

        public void EditarLivro(Livro livro)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"UPDATE Livros 
                                 SET ISBN                  = @ISBN,
                                     Titulo                = @Titulo,
                                     Autor                 = @Autor,
                                     AnoPublicacao         = @AnoPublicacao,
                                     ExemplaresDisponiveis = @ExemplaresDisponiveis
                                 WHERE IdLivro = @IdLivro";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdLivro", livro.IdLivro);
                cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);
                cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", livro.Autor);
                cmd.Parameters.AddWithValue("@AnoPublicacao", (object)livro.AnoPublicacao ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ExemplaresDisponiveis", livro.ExemplaresDisponiveis);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //eliminar livro

        public void EliminarLivro(int idLivro)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Livros WHERE IdLivro = @IdLivro";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdLivro", idLivro);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //pesquisar livro

        public List<Livro> PesquisarLivros(string textoPesquisa)
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"SELECT * FROM Livros 
                                 WHERE Titulo LIKE '%' + @Texto + '%' 
                                 OR Autor LIKE '%' + @Texto + '%'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Texto", textoPesquisa);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    livros.Add(new Livro
                    {
                        IdLivro = (int)reader["IdLivro"],
                        ISBN = reader["ISBN"].ToString(),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        AnoPublicacao = reader["AnoPublicacao"] == DBNull.Value ? null : (int?)reader["AnoPublicacao"],
                        ExemplaresDisponiveis = (int)reader["ExemplaresDisponiveis"]
                    });
                }
            }
            return livros;
        }
    }
}