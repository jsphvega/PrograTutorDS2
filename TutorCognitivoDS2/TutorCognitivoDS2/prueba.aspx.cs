using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using TutorCognitivoDS2.accesoADatos;

namespace TutorCognitivoDS2
{
    public partial class prueba : System.Web.UI.Page
    {
       

        //private static string conection;
        //private static MySqlConnection conectar;
        //private MySqlCommand comando;
       
      



        protected void Page_Load(object sender, EventArgs e)
        {
          try
            {

                //conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                //conectar = new MySqlConnection(conection);
                //conectarBD();
                //conectar.Open();
                //comando = new MySqlCommand();
                //comando.Connection = conectar;
                //comando.CommandText = "INSERT INTO usuario(Nombre,Apellido1,Apellido2,Correo,Contraseña,Tipo) VALUES(@Nombre,@Apellido1,@Apellido2,@Correo,@Contraseña,@Tipo)";
                //comando.Parameters.AddWithValue("@Nombre", "maria");
                //comando.Parameters.AddWithValue("@Apellido1", "maria");
                //comando.Parameters.AddWithValue("@Apellido2", "maria");
                //comando.Parameters.AddWithValue("@Correo", "maria");
                //comando.Parameters.AddWithValue("@Contraseña", "maria");
                //comando.Parameters.AddWithValue("@Tipo", 3);
                //comando.ExecuteNonQuery();
                //conectar.Close();

                VerificacionDatos dato = new VerificacionDatos();

                if (dato.verificarInicioSesion("hola", "maria", "3") == true)
                {
                    Response.Write("se encuentra en la base");
                }
                else
                {
                    Response.Write("no se encuentra en la base");
                }


                // string tutores= "SELECT nombre FROM tutor Limit 0";

                //MySqlCommand comando2 = new MySqlCommand(tutores,conectar);
                //MySqlDataReader lectura = comando2.ExecuteReader();

                //  while (lectura.Read())
                // {
                // string nombre = lectura.GetString(0);

                // }

                Response.Write("'conexion exitosa' ");
               
            }
           catch (Exception)
           {
                Response.Write("'conexion no exitosa' ");

            }
       }
  }
}