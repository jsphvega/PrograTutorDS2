using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using TutorCognitivoDS2.DTO;

namespace TutorCognitivoDS2.accesoADatos
{
    public class DatoInicioSesion
    {
        private MySqlCommand comando;
        private MySqlCommand comando2;
        private string conection;
        private MySqlConnection conectar;
        private String consulta;
        MySqlDataReader lectura;


        public void conectarBD()
        {
            try
            {
                conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                conectar = new MySqlConnection(conection);
            }
            catch (Exception)
            {

            }
        }
        public Boolean esRegistrado(DTOInicioSesion inicioSesion)
        {
            conectarBD();
            conectar.Open();
            comando = new MySqlCommand();
            comando.Connection = conectar;
            comando.CommandText = "Select correo, contraseña from usuario where correo= ";
            comando.ExecuteNonQuery();
            conectar.Close();
        }
}