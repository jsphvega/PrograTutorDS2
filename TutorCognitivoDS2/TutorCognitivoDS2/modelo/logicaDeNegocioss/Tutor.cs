using dto;
using System;

namespace logicaDeNegocios
{
    public class Tutor : Usuario
    {
        private DateTime vencimiento;
        private Array tutores;

        public Tutor(DTOUsuario pUsuario, DateTime pVencimiento)
        : base(pUsuario.Nombre, pUsuario.Correo,
                  pUsuario.Contraseña1, pUsuario.Apellido1, pUsuario.Apellido2,)
        {
            Nombre = pUsuario.Nombre;
            Apellido1 = pUsuario.Apellido1;
            Apellido2 = pUsuario.Apellido2;
            Correo = pUsuario.Correo;
            Contraseña = pUsuario.Contraseña1;
            vencimiento = pVencimiento;
           
        }

        private  void registrarUsuario()
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