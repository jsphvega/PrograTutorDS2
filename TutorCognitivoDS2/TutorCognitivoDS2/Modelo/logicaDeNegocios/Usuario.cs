using System;

namespace logicaDeNegocios
{
    public abstract class Usuario
    {
        String nombre;
        String correo;
        String contraseña;
        String carrera;

        public Usuario(String pNombre, String pCorreo, String pContraseña, String pCarrera)
        {

        }

        public abstract void registrarUsuario();

        public abstract String toString();

    }
}