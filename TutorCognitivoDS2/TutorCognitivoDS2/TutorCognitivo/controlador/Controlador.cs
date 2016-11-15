using dto;
using logicaDeDatos;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace controlador
{
    public class Controlador
    {
        private AdapterJava adaptador;

        public List<String[]> obtenerListaCarreras()
        {
            DatoCarrera dc = new DatoCarrera();
            List<String[]> lista = dc.Consulta();

            return lista;
        }

        public void insertarUsuarioFinal(DTOUsuario dto)
        {
            DatoUsuario DU = new DatoUsuario();
            DU.registrarUsuario(dto);

        }

        public void enviarCorreoCategoria()
        {


        }

        public void enviarCorreoConsulta()
        {


        }

    }
}