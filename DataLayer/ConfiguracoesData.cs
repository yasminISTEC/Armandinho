using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class ConfiguracoesData
    {
        //ler configuracaoes

        public Configuracao LerConfiguracao()
        {
            Configuracao config = null;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Configuracoes WHERE IdConfiguracao = 1";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    config = new Configuracao
                    {
                        IdConfiguracao = (int)reader["IdConfiguracao"],
                        PrazoDias = (int)reader["PrazoDias"],
                        ValorMultaPorDia = (decimal)reader["ValorMultaPorDia"]
                    };
                
                }
            }
            return config;
    

        }
        //atualizar configuracoes

        public void AtualizarConfiguracao(Configuracao config)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query = @"UPDATE Configuracoes 
                                 SET PrazoDias        = @PrazoDias,
                                     ValorMultaPorDia = @ValorMultaPorDia
                                 WHERE IdConfiguracao = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PrazoDias", config.PrazoDias);
                cmd.Parameters.AddWithValue("@ValorMultaPorDia", config.ValorMultaPorDia);

                con.Open();
                cmd.ExecuteNonQuery();

            }

        }
    }
}

