using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TutorCognitivoDS2.accesoADatos
{
    public class DatoUsuario
       
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


        public void registrarUsuario(dto.DTOUsuario usuario)
        {
            try
            {
                conectarBD();
                conectar.Open();
                comando = new MySqlCommand();
                comando.CommandText = "INSERT INTO usuario(Nombre,Apellido1,Apellido2,Correo,Contraseña,Tipo) VALUES(@Nombre,@Apellido1,@Apellido2,@Correo,@Contraseña,@Tipo)";
                comando.Parameters.AddWithValue("@Nombre", "");
                comando.Parameters.AddWithValue("@Apellido1", "Mante");
                comando.Parameters.AddWithValue("@Apellido2", "Mante");
                comando.Parameters.AddWithValue("@Correo", "Mante");
                comando.Parameters.AddWithValue("@Contraseña", "Mante");
                comando.Parameters.AddWithValue("@Tipo", "Mante");
                conectar.Close();


            }
            catch (Exception)
            {

            }

        }

        public void consultarUsuario(int rol)
        {
            try
            {

               consulta= "SELECT * FROM usuario where Limit 0";

                comando2 = new MySqlCommand(consulta,conectar);
                lectura = comando2.ExecuteReader();

                while (lectura.Read())
                 {
                 string nombre = lectura.GetString(1);
                    String apellido1 = lectura.GetString(2);
                    String apellido2 = lectura.GetString(3);
                    String correo = lectura.GetString(4);




                }

            }
            catch
            {
            }


        }

    }
}