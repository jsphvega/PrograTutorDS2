using dto;
using System;

namespace logicaDeNegocios
{
    public class Final : Usuario
    {

        public Final(DTOUsuario pUsuario)
            : base(pUsuario.Nombre, pUsuario.Apellido1, pUsuario.Apellido2, pUsuario.Correo,
                  pUsuario.Contraseña1, pUsuario.Carrera)
        {

        }

        public override void registrarUsuario()
        {

        }

        public override string toString()
        {
            return null;
        }

    }
}