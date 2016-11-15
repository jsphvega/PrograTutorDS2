using dto;
using System;

namespace logicaDeNegocios
{
    public class Final : Usuario
    {
        private Final(DTOUsuario pUsuario) 
        {
            Nombre = pUsuario.Nombre;
            Apellido1 = pUsuario.Apellido1;
            Apellido2 = pUsuario.Apellido2;
            Correo = pUsuario.Correo;
            Contraseña = pUsuario.Contraseña1;
            Carrera = pUsuario.Carrera;
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}