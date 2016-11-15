using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class DatoCategoria : ConexionBD
    {
        private MySqlCommand comandoCategoria;
        private String coneccion;
        private MySqlConnection conectado;
        private MySqlDataReader consultaCategoria;

        public void conectarBD()
        {
        }

        public void registrarCategoria(DTOCategoria categoria)
        {
        }

        public void consultarCategoria(DTOCategoria categoria)
        {
        }
    }
}