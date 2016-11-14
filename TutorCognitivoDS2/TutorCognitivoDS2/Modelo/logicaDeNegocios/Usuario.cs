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

        public Usuario(String pNombre, String pApellido1, String pApellido2, String pCorreo, String pContraseña, int pCarrera)
        {

        }

        public abstract void registrarUsuario();

        public abstract String toString();

    }
}