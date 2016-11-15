using System;

namespace logicaDeNegocios
{
    public abstract class Usuario
    {
        private String nombre;
        private String correo;
        private String contraseña;
        private int carrera;
        private String apellido1;
        private String apellido2;

        public Usuario(String pNombre, String pApellido1, String pApellido2, String pCorreo, String pContraseña, int pCarrera)
        {
        }

        public abstract String toString();
    }
}