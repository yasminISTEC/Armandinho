using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace BusinessLayer
{
    public class SociosBusiness
    {
        private SociosData _sociosData = new SociosData();

        //validar socio

        public string ValidarSocio(Socio socio)
        {
            if (string.IsNullOrWhiteSpace(socio.NumeroSocio))
                return "O Numero socio 'e obrigatorio";

            if (socio.NumeroSocio.Length > 20)

                return "O numero de Socio nao pode ser mais de 20 caracteres";

            if (string.IsNullOrWhiteSpace(socio.Nome))
                return "O Nome é obrigatório.";

            if (!string.IsNullOrWhiteSpace(socio.Telefone))
                if (socio.Telefone.Length != 9)
                    return "O numero deve ter 9 digitos";

            return null;
        }

        //inserir com validacao

        public string InserirSco(Socio socio)
        {
            string erro = ValidarSocio(socio);
            if (erro != null) return erro;

            _sociosData.InserirSocios(socio);
            return null;

        }
        //editar

        public string EditarSocio (Socio socio)
        {
            string erro = ValidarSocio(socio);
            if (erro != null) return erro;

            _sociosData.EditarSocio(socio);
            return null;
        }


        //eliminar

        public void EliminarSocio(int idSocio)
        {
            _sociosData.EliminarSocio(idSocio);

        }

        //listar

        public List<Socio> ListarSocio()
        {
            return _sociosData.ListarSocios();
        }

        //pesquisar

        public List<Socio> PesquisarSocios(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return _sociosData.ListarSocios();

            return _sociosData.PesquisarSocios(texto);
        }

    }
}
   