using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorCognitivoDS2.DTO
{
    public class DTOInicioSesion
    {
        private String correo;
        private String contraseña;

        public DTOInicioSesion(String pCorreo, String pContraseña)
        {
            correo = pCorreo;
            contraseña = pContraseña;
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
    }
}