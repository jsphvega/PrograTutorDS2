using dto;
using System;

namespace logicaDeNegocios
{
    public class DecoradorAdministrador : Usuario
    {
        public DecoradorAdministrador(DTOUsuario pUsuario) : base(pUsuario.Nombre, pUsuario.Correo, pUsuario.Contraseņa, pUsuario.Carrera)
        {
        }

        public void AdapterAdministrador()
        {
            // TODO implement here
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