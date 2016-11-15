using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class DatoUsuario : ConexionBD
    {
        private MySqlCommand comandoUsuario;
        private String conection;
        private MySqlConnection conectado;
        private MySqlDataReader consulta;

        public void conectarBD()
        {
        }

        public void registrarUsuario(DTOUsuario usuario)
        {
        }

        public void consultarTutores()
        {
        }

        public void consultarFinales()
        {
        }

        public void consultarDatosTutor(int ID)
        {
        }

        public void consultarDatosFinal(int ID)
        {
        }
    }
}