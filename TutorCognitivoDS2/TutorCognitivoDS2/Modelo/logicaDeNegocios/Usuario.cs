using System;

namespace logicaDeNegocios
{
    public abstract class Usuario
    {
        String nombre;
        String apellido1;
        String apellido2;
        String correo;
        String contraseña;
        int carrera;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public int Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }

        public Usuario(String pNombre, String pApellido1, String pApellido2, String pCorreo, String pContraseña, int pCarrera)
        {

        }

        public abstract void registrarUsuario();

        public abstract String toString();

    }
}