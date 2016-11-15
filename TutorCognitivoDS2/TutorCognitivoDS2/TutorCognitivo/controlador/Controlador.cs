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
        private AdapterJava adaptador;

        public void mensaje(String error)
        {
            string script = @"<script type='text/javascript'>alert('" + error + "');</script>";
            ScriptManager.RegisterStartupScript(null, typeof(Page), "alerta", script, false);
        }

        public List<String[]> obtenerListaCarreras()
        {
            DatoCarrera sCarrera = new DatoCarrera();
            List<String[]> lista = sCarrera.Consulta();

            return lista;
        }

        public void insertarUsuarioFinal(DTOUsuario pUsuario)
        {
            DatoUsuario sUsuario = new DatoUsuario();
            sUsuario.registrarUsuario(pUsuario);

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