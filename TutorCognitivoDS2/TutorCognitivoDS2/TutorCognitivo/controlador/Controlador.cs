using dto;
using logicaDeDatos;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorCognitivoDS2.TutorCognitivo.controlador;

namespace controlador
{
    public class Controlador

    {
        private Adaptador adaptador; 
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

        /*****************************************/

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

        public void crearBitacora()
        {


        }
        public void crearUsuario()
        {

        }
    }
