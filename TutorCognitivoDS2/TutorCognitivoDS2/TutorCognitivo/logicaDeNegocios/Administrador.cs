using dto;
using System;

namespace logicaDeNegocios
{
    public class Administrador : Usuario
    {
        public Administrador(DTOUsuario pUsuario) : base(pUsuario.Nombre, pUsuario.Apellido1, pUsuario.Apellido2, pUsuario.Correo, pUsuario.Contraseña1, pUsuario.Carrera)
        {
        }

        public override string toString()
        {
            return null;
        }
    }
}