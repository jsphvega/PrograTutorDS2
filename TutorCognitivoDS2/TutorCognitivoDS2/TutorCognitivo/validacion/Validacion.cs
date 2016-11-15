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
                return "El nombre no debe estar vacío";


            // validar contraseñas iguales
            //Que correo no exista
            //que este todo lleno

            return String.Empty;
        }

        public static string validarContrasena(DTOUsuario pUsuario)
        {
            if( string.Equals(pUsuario.Contraseña1, pUsuario.Contraseña2))
            {
                return "Las contrasenas no coinciden";
            }
            return string.Empty;
        }

        public static string validarCorreoExistente(DTOUsuario pUsuario)
        {
            //if(CONSULTA A BASE DE DATOS A VER SI EXISTE)
            return "Correo existente";
        }

        public static Boolean validarCampos(DTOUsuario pUsuario)
        {
            Boolean flag = true;
            if (pUsuario.Nombre.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Apellido1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Apellido2.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Correo.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Carrera.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Contraseña1.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            if (pUsuario.Contraseña2.Equals(String.Empty))
            {
                flag = false;
                return flag;
            }
            else
            {
                return flag;
            }
        }
        public static string validarDigitosContrasena(DTOUsuario pUsuario)
        {
            if (pUsuario.Contraseña1.Length < 8)
                return "Contrasena debe tener al menos 8 caracteres";
            return string.Empty;
        }

        public static string validarCorreoValido(DTOUsuario pUsuario)
        {
            if (pUsuario.Correo.IndexOf("@") == -1)
            {
                return "No corresponde a un correo";
            }
            if (pUsuario.Correo.IndexOf(".com") == -1)
            {
                return "No corresponde a un correo";
            }
            return string.Empty;

        }
    }
}