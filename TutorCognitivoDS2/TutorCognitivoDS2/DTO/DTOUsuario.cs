using System;

namespace dto
{
    public class DTOUsuario
    {
        private String nombre;
        private String correo;
        private String contraseña;
        private String carrera;

        public DTOUsuario(String pNombre, String pCorreo, String pContraseña, String pCarrera)
        {

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
    }
}