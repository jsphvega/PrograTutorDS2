using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class DatoUsuario : ConexionBD
    {
        private MySqlCommand comandoUsuario;
        private string conection;
        private MySqlConnection conectado;
        private MySqlDataReader consulta;

        public void conectarBD()
        {
            try
            {
                conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                conectado = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }

        public void registrarUsuario(DTOUsuario usuario)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoUsuario = new MySqlCommand();
                comandoUsuario.Connection = conectado;

                comandoUsuario.CommandText = "INSERT INTO usuario(nombre,apellido1,apellido2,correo,contrasena,tipo,carrera_idcarrera) "
                       + "VALUES('" + usuario.Nombre + "','" + usuario.Apellido1 + "','" + usuario.Apellido2 + "','" + usuario.Correo
                       + "','" + usuario.Contraseņa1 + "',3," + usuario.Carrera + ")";

                comandoUsuario.ExecuteNonQuery();
                conectado.Close();
            }
            catch (Exception)
            {

            }
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