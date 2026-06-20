using DataLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class ConfiguracoesBusiness
    {
        private ConfiguracoesData _configData = new ConfiguracoesData();


        //validar configuracao

        public string ValidarConfiguracao(Configuracao config)
        {
            if (config.PrazoDias <= 0)
                return "O prazo de dias deve ser maior que zero.";

            if (config.PrazoDias > 365)
                return "O prazo de dias não pode ser superior a 365.";

            if (config.ValorMultaPorDia < 0)
                return "O valor da multa não pode ser negativo.";

            return null; 
        }
        //ler configuracaoes

        public Configuracao LerConfiguracao()
        {
            return _configData.LerConfiguracao();
        }

        //atualizar configuracaoes
        public string AtualizarConfiguracao(Configuracao config)
        {
            string erro = ValidarConfiguracao(config);
            if (erro != null) return erro;

            _configData.AtualizarConfiguracao(config);
            return null;
        }
    }
}
    

