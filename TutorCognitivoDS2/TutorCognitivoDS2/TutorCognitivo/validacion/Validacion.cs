using dto;
using System;

namespace validacion
{
    public class Validacion
    {

        public static String validarUsuario(DTOUsuario pUsuario)
        {
            String Consulta = String.Empty;

            if (!validarCampos(pUsuario))
                Consulta = "No pueden haber datos vacíos";
            else
            {
                Consulta += validarContrasena(pUsuario) + (Consulta == String.Empty ? String.Empty : ", ");
                Consulta += validarCorreoExistente(pUsuario) + (Consulta == String.Empty ? String.Empty : ", ");
                Consulta += validarDigitosContrasena(pUsuario) + (Consulta == String.Empty ? String.Empty : ", ");
                Consulta += validarCorreoValido(pUsuario);
            }

            return Consulta;
        }

        private static string validarContrasena(DTOUsuario pUsuario)
        {
            if (string.Equals(pUsuario.Contraseña1, pUsuario.Contraseña2))
            {
                return "Las contrasenas no coinciden";
            }

            return string.Empty;
        }

        private static string validarCorreoExistente(DTOUsuario pUsuario)
        {
            //if(CONSULTA A BASE DE DATOS A VER SI EXISTE)
            return "Correo existente";
        }

        private static Boolean validarCampos(DTOUsuario pUsuario)
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
        private static string validarDigitosContrasena(DTOUsuario pUsuario)
        {
            if (pUsuario.Contraseña1.Length < 8)
                return "Contrasena debe tener al menos 8 caracteres";
            return string.Empty;
        }

        private static string validarCorreoValido(DTOUsuario pUsuario)
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