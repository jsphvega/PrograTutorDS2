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

        }

        public override void registrarUsuario()
        {
            // TODO implement here
        }

        public override String toString()
        {
            // TODO implement here
            return null;
        }

    }
}