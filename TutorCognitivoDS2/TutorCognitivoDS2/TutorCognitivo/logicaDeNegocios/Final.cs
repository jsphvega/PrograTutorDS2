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
            String datos;
            datos = "Nombre";
            datos += "Apellido1";
            datos += "Apellido2";
            datos += "Correo";
            datos += "Fecha vencimiento contrato";
            return datos;
        }
    }
}