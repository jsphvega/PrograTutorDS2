using dto;
using System;

namespace logicaDeNegocios
{
    public class Final : Usuario
    {

        public Final(DTOUsuario pUsuario) : base(pUsuario.Nombre, pUsuario.Correo, pUsuario.Contrase�a, pUsuario.Carrera)
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