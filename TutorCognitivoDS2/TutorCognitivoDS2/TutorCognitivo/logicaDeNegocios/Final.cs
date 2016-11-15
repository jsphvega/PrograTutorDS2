using dto;
using System;

namespace logicaDeNegocios
{
    public class Final : Usuario
    {
        private Final(DTOUsuario pUsuario) : base(pUsuario.Nombre, pUsuario.Apellido1, pUsuario.Apellido2, pUsuario.Correo, pUsuario.Contrase�a1, pUsuario.Carrera)
        {
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}