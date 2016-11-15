using dto;
using System;

namespace logicaDeNegocios
{
    public class Tutor : Usuario
    {
        private DateTime vencimiento;

        public Tutor(DTOUsuario pUsuario, DateTime pVencimiento)
            : base(pUsuario.Nombre, pUsuario.Apellido1, pUsuario.Apellido2, pUsuario.Correo, pUsuario.Contraseña1, pUsuario.Carrera)
        {

        }

        public override string toString()
        {
            String datos;
            datos = "Nombre";
            datos += "Apellido1";
            datos += "Apellido2" ;
            datos += "Correo" ;
            datos += "Fecha vencimiento contrato";
            return datos;
        }
    }
}