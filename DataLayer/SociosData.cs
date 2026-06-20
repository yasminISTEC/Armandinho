using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataLayer
{
    public class SociosData
    {
        //listar todos os socios
        public List<Socio> ListarSocios()
        {
            List<Socio> socios = new List<Socio>();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Socios";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    socios.Add(new Socio
                    {
                        IdSocio = (int)reader["IdSocio"],
                        NumeroSocio = reader["NumeroSocio"].ToString(),
                        Nome = reader["Nome"].ToString()
                    });
                }
            }
            return socios;
        }

        //inserir socios

        public void InserirSocios(Socio socio)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Socios (NumeroSocio, Nome, Telefone) VALUES
                    (@NumeroSocio, @Nome', @Telefone)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@NumeroSocio", socio.NumeroSocio);
                cmd.Parameters.AddWithValue("@Nome", socio.Nome);
                cmd.Parameters.AddWithValue("@Telefone", socio.Telefone);

                con.Open();

                cmd.ExecuteNonQuery();

            }
        }
        //editar socio

        public void EditarSocio(Socio socio)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"UPDATE Socios SET 
                    NumeroSocio = @NumeroSocio,
                    Nome = @Nome
                    Telefone = @Telefone    
                            WHERE IdSOcio + @IdSocio";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdSocio", socio.IdSocio);
                cmd.Parameters.AddWithValue("@NumeroSocio", socio.NumeroSocio);
                cmd.Parameters.AddWithValue("@Nome", socio.Nome);
                cmd.Parameters.AddWithValue("@Telefone", socio.Telefone);
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        //eliminar socio

        public void EliminarSocio(int idSocio)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Socios WHERE IdSocio = @IdSocio";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdSocio", idSocio);

                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        //pesquisar socios

        public List<Socio> PesquisarSocios(string texto)
        {
            List<Socio> socios = new List<Socio>();

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"SELECT * FROM Socios
                    WHERE Nome LIKE '%' + @Texto + '%'
                                 OR NumeroSocio LIKE '%' + @Texto + '%'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Texto", texto);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    socios.Add(new Socio
                    {
                        IdSocio = (int)reader["IdSocio"],
                        NumeroSocio = reader["NumeroSocio"].ToString(),
                        Nome = reader["Nome"].ToString(),
                        Telefone = reader["Telefone"].ToString()
                    });
                }
            }
            return socios;
            
        }

    }
}

