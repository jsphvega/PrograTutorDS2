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
            this.nombre = pNombre;
            this.correo = pCorreo;
            this.contraseña = pContraseña;
            this.carrera = pCarrera;
            this.apellido2 = pApellido2;
            this.apellido1 = pApellido1;
        }

        public abstract String toString();
    }
}