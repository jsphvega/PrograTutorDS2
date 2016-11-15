using System;
using dto;

namespace logicaDeNegocios
{
    public abstract class Usuario
    {
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String correo;
        private String contraseña;
        private int carrera;


        public Usuario(String pNombre, String pCorreo, String pContraseña, String pCarrera,String pApellido1, String pApellido2)
        {
            nombre = pNombre;
            apellido1 = pApellido1;
            apellido2 = pApellido2;
            correo = pCorreo;
            contraseña = pContraseña;

        }
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

      
        public abstract String toString();

    }
}