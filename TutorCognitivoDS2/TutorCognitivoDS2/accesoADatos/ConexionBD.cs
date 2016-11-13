using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TutorCognitivoDS2.accesoADatos
{
    public class ConexionBD
    {

        private string conection;
        private MySqlConnection conectar;

        public ConexionBD()
        {

        }
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

        public void abrirConexion()
        {
            try
            {
                conectar.Open();
            }
            catch (Exception)
            {

            }
        }
        public void cerrarConexion()
        {
            try
            {
                conectar.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}