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
                        AnoPublicaco = reader["AnoPublicacao"] == DBNull.Value ? null : (int?)reader["AnoPublicacao"],
                        ExemplaresDisponiveis = (int)reader["ExemplaresDisponiveis"]
                    });
                }
            }
            return livros;
        }

    }
}
