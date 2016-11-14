using dto;
using System;

namespace logicaDeNegocios
{
    public class Tutor : Usuario
    {
        private DateTime vencimiento;

        public Tutor(DTOUsuario pUsuario, DateTime pVencimiento)
        : base(pUsuario.Nombre, pUsuario.Apellido1, pUsuario.Apellido2, pUsuario.Correo,
                  pUsuario.Contraseña1, pUsuario.Carrera)
        {
            Nombre = pUsuario.Nombre;
            Apellido1 = pUsuario.Apellido1;
            Apellido2 = pUsuario.Apellido2;
            Correo = pUsuario.Correo;
            Contraseña = pUsuario.Contraseña1;
            Carrera = pUsuario.Carrera;
        }

        public override void registrarUsuario()
        {
            // TODO implement here
            //SUPONGO QUE AQUI VA EL METODO DE LA BASE DE DATOS
        }

        public override String toString()
        {
            // TODO implement here
            return null;
        }

    }
}