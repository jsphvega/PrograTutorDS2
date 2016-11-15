using dto;
using logicaDeDatos;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlador
{
    public class Controlador
    {


        public void mensajeInterfaz(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(null, typeof(Page), "Alerta", script, false);
        }

        /*****************************************/
        
        public List<String[]> obtenerListaCarreras()
        {
            DatoCarrera sCarrera = new DatoCarrera();
            List<String[]> lista = sCarrera.Consulta();

            return lista;
        }

        public void insertarUsuarioFinal(DTOUsuario pUsuario)
        {
            try
            {
                DatoUsuario sUsuario = new DatoUsuario();
                sUsuario.registrarUsuario(pUsuario);
                mensajeInterfaz("Datos insertados correctamente");
            }
            catch
            {
                mensajeInterfaz("No se pudieron insertar los datos");
            }
        }

        public bool verificarSesion(DTOInicioSesion pSesion)
        {
            VerificacionDeDatos sSesion = new VerificacionDeDatos();
            return sSesion.verificarInicioSesion(pSesion);
        }

        public void enviarCorreoCategoria()
        {


        }

        public void enviarCorreoConsulta()
        {


        }

    }
}