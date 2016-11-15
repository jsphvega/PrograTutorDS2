using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class DatoCarrera : ConexionBD
    {
        private MySqlCommand comandoCarrera;
        private String conection;
        private MySqlConnection conectado;
        private MySqlDataReader consultaCarrera;

        public void conectarBD()
        {
        }
    }
}