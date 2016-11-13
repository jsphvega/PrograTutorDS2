using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TutorCognitivoDS2
{
    public partial class prueba : System.Web.UI.Page
    {
       

        private static string conection;
        private static MySqlConnection conectar;

        
       


        protected void Page_Load(object sender, EventArgs e)
        {
          try
            {

                conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                conectar = new MySqlConnection(conection);
                conectar.Open();
                 MySqlCommand comando = new MySqlCommand();
                comando.Connection = conectar;
                comando.CommandText = "INSERT INTO carrera(Nombre) VALUES(@Nombre)";
                comando.Parameters.AddWithValue("@Nombre", "Mante");




                //comando.CommandText = "INSERT INTO tutor(nombre) VALUES(@nombre)";
                //comando.Parameters.AddWithValue("@nombre", "Maria Jose");
                comando.ExecuteNonQuery();


                // string tutores= "SELECT nombre FROM tutor Limit 0";

                //MySqlCommand comando2 = new MySqlCommand(tutores,conectar);
                //MySqlDataReader lectura = comando2.ExecuteReader();

                //  while (lectura.Read())
                // {
                // string nombre = lectura.GetString(0);

                // }

                Response.Write("'conexion exitosa' ");
                conectar.Close();
            }
           catch (Exception)
           {
                Response.Write("'conexion no exitosa' ");

            }
       }
  }
}