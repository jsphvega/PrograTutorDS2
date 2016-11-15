using dto;
using logicaDeDatos;
using System.Collections.Generic;
using logicaDeIntegracion;

namespace controlador
{
    public class Controlador
    {
        private AdapterJava adaptador;

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