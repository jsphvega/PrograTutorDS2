using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace TutorCognitivoDS2.accesoADatos
{
    public class ConsultaCarrera
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
         
        public void cargarListBox()
        {
            conectarBD();
            conectar.Open();
            comando2 = new MySqlCommand();
            comando2.Connection = conectar;
            comando2.CommandText = "SELECT * From carrera";
            lectura = comando2.ExecuteReader();
            lectura.Read();
            conectar.Close();
        }

      
}
}