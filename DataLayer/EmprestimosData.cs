using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataLayer
{
    public class EmprestimosData
    {
        //listar todos os emprestimos

        public List<Emprestimo> ListarEmprestimo()
        {
            List<Emprestimo> emprestimos = new List<Emprestimo>();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        E.IdEmprestimo,
                        E.IdLivro,
                        E.IdSocio,
                        E.DataEmprestimo,
                        E.DataPrevistaDevolucao,
                        E.DataDevolucao,
                        E.Estado,
                        S.Nome    AS NomeSocio,
                        L.Titulo  AS TituloLivro
                    FROM Emprestimos E
                    JOIN Socios S ON E.IdSocio = S.IdSocio
                    JOIN Livros L ON E.IdLivro = L.IdLivro";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emprestimos.Add(new Emprestimo
                    {
                        IdEmprestimo = (int)reader["IdEmprestimo"],
                        IdLivro = (int)reader["IdLivro"],
                        IdSocio = (int)reader["IdSocio"],
                        DataEmprestimo = (DateTime)reader["DataEmprestimo"],
                        DataPrevistaDevolucao = (DateTime)reader["DataPrevistaDevolucao"],
                        DataDevolucao = reader["DataDevolucao"] == DBNull.Value ? null : (DateTime?)reader["DataDevolucao"],
                        Estado = reader["Estado"].ToString(),
                        NomeSocio = reader["NomeSocio"].ToString(),
                        TituloLivro = reader["TituloLivro"].ToString()
                    });
                }
            }
            return emprestimos;
        }
        //listar emprestimos

        public List<Emprestimo> ListarEmAberto()
        {
            List<Emprestimo> emprestimos = new List<Emprestimo>();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        E.IdEmprestimo,
                        E.IdLivro,
                        E.IdSocio,
                        E.DataEmprestimo,
                        E.DataPrevistaDevolucao,
                        E.DataDevolucao,
                        E.Estado,
                        S.Nome    AS NomeSocio,
                        L.Titulo  AS TituloLivro
                    FROM Emprestimos E
                    JOIN Socios S ON E.IdSocio = S.IdSocio
                    JOIN Livros L ON E.IdLivro = L.IdLivro
                    WHERE E.Estado = 'Por Devolver'";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emprestimos.Add(new Emprestimo
                    {
                        IdEmprestimo = (int)reader["IdEmprestimo"],
                        IdLivro = (int)reader["IdLivro"],
                        IdSocio = (int)reader["IdSocio"],
                        DataEmprestimo = (DateTime)reader["DataEmprestimo"],
                        DataPrevistaDevolucao = (DateTime)reader["DataPrevistaDevolucao"],
                        DataDevolucao = null,
                        Estado = reader["Estado"].ToString(),
                        NomeSocio = reader["NomeSocio"].ToString(),
                        TituloLivro = reader["TituloLivro"].ToString()
                    });
                }
            }
            return emprestimos;
        }
        //registrar emprestimo

        public void RegistrarEmprestimo(Emprestimo emprestimo)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Emprestimos (IdLivro, IdSocio, DataEmprestimo, DataPrevistaDevolucao, Estado)
                    VALUES (@IdLivro, @IdSocio, @DataEmprestimo, @DataPrevistaDevolucao, 'Por Devolver');

                    UPDATE Livros 
                    SET ExemplaresDisponiveis = ExemplaresDisponiveis - 1
                    WHERE IdLivro = @IdLivro;";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdLivro", emprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@IdSocio", emprestimo.IdSocio);
                cmd.Parameters.AddWithValue("@DataEmprestimo", emprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@DataPrevistaDevolucao", emprestimo.DataPrevistaDevolucao);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Registar 

        public void RegistrarDevolucao(int idEmprestimo, int idLivro)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"
                    UPDATE Emprestimos
                    SET DataDevolucao = GETDATE(),
                        Estado = CASE 
                                    WHEN GETDATE() > DataPrevistaDevolucao THEN 'Devolvido com Atraso'
                                    ELSE 'Devolvido'
                                 END
                    WHERE IdEmprestimo = @IdEmprestimo;

                    UPDATE Livros
                    SET ExemplaresDisponiveis = ExemplaresDisponiveis + 1
                    WHERE IdLivro = @IdLivro;";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdEmprestimo", idEmprestimo);
                cmd.Parameters.AddWithValue("@IdLivro", idLivro);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //eliminar emprestimo

        public void EliminarEmprestimo(int idEmprestimo)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Emprestimos WHERE IdEmprestimo = @IdEmprestimo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdEmprestimo", idEmprestimo);

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}  


