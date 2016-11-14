
using dto;
using System;

namespace logicaDeNegocios
{
    public class AdapterAdministrador : Usuario
    {

        public AdapterAdministrador(DTOUsuario pUsuario) : base(pUsuario.Nombre, pUsuario.Correo, pUsuario.Contraseña, pUsuario.Carrera)
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