using dto;
using System;

namespace logicaDeNegocios
{
    public class Tutor : Usuario
    {
        private DateTime vencimiento;

        public Tutor(DTOUsuario pUsuario, DateTime pVencimiento)
            : base(pUsuario.Nombre, pUsuario.Apellido1, pUsuario.Apellido2, pUsuario.Correo, pUsuario.Contrase�a1, pUsuario.Carrera)
        {
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}