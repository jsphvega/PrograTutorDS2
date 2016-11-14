using System;

namespace dto
{
    public class DTOUsuario
    {
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String correo;
        private String contraseña;
        private String carrera;

        public DTOUsuario(String pNombre, String pApellido1, String pApellido2, String pCorreo, String pContraseña, String pCarrera)
        {
            nombre = pNombre;
            Apellido1 = pApellido1;
            Apellido2 = pApellido2;
            correo = pCorreo;
            contraseña = pContraseña;
            carrera = pCarrera;
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

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
    }
}