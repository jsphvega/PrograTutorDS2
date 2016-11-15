using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class DatoBitacora : ConexionBD
    {
        private MySqlCommand comandoBitacora;
        private String conection;
        private MySqlConnection conectado;
        private MySqlDataReader consultaBitacora;

        public void conectarBD()
        {
        }

        public void registrarBitacora(DTOBitacora bitacora)
        {
        }

        public void consultarBitacora(DTOBitacora bitacora)
        {
        }
    }
}