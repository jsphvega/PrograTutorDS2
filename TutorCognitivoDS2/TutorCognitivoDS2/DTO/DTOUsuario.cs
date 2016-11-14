using System;

namespace dto
{
    //clase que corresponde al DTO de Inicio de usuario
    public class DTOUsuario
    {
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String correo;
        private String contraseña1;
        private String contraseña2;
        private int carrera;

        public DTOUsuario(String pNombre, String pApellido1, String pApellido2, String pCorreo, String pContraseña1, String pContraseña2, int pCarrera)
        {
            nombre = pNombre;
            Apellido1 = pApellido1;
            Apellido2 = pApellido2;
            correo = pCorreo;
            contraseña1 = pContraseña1;
            contraseña2 = pContraseña2;
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

        public string Contraseña1
        {
            get { return contraseña1; }
            set { contraseña1 = value; }
        }

        public string Contraseña2
        {
            get { return contraseña2; }
            set { contraseña2 = value; }
        }

        public int Carrera
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