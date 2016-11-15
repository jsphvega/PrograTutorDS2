using dto;
using System;

namespace validacion
{
    public class Validacion
    {

        private static Boolean esVacio(String pTexto)
        {
            return pTexto.Equals(String.Empty);
        }

        public static String validarUsuario(DTOUsuario pUsuario)
        {
            if (esVacio(pUsuario.Nombre))
                return "El nombre no debe estar vac�o";

            // validar contrase�as iguales
            //Que correo no exista
            //que este todo lleno

            return String.Empty;
        }
    }
}