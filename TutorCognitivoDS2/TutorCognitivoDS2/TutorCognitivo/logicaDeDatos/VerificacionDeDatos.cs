using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class VerificacionDeDatos : ConexionBD
    {
        private MySqlCommand comando;
        private String conection;
        private MySqlConnection conectado;
        private MySqlDataReader lectura;

        public void conectarBD()
        {
        }

        public bool verificarInicioSesion(DTOUsuario usuario, String pTipo)
        {
            return false;
        }

        public bool verificarUsuarioExistente(DTOUsuario usuario)
        {
            return false;
        }

        public bool verificarCorreo(String pCorreo)
        {
            return false;
        }
    }
}