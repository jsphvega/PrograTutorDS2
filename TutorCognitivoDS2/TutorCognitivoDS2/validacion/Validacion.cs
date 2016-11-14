using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorCognitivoDS2.validacion
{
    public static class Validacion
    {
        private static Boolean esVacio(String pTexto)
        {
            return pTexto.Equals(String.Empty);
        }

        public static String validarUsuario(DTOUsuario pUsuario)
        {
            if (esVacio(pUsuario.Nombre))
                return "El nombre no debe estar vacío";

            // validar contraseñas iguales
            //Que correo no exista
            //que este todo lleno

            return String.Empty;
        }
    }
}