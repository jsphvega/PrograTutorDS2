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
                try
                {
                    conection = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                    conectado = new MySqlConnection(conection);
                }
                catch (Exception)
                {

                }
            }

            public void registrarBitacora(DTOBitacora bitacora)
        {
            try
            {
                conectarBD();
                conectado.Open();
                comandoBitacora = new MySqlCommand();
                comandoBitacora.Connection = conectado;
                comandoBitacora.CommandText = "INSERT INTO usuario(fechaHora,Accion,contrase�a) VALUES(@fechaHora,@accion,@contrase�a)";
                comandoBitacora.Parameters.AddWithValue("@fechaHora", bitacora.FechaHora);
                comandoBitacora.Parameters.AddWithValue("@accion", bitacora.Accion);
                comandoBitacora.Parameters.AddWithValue("@contrase�a", bitacora.Contrase�a);
                comandoBitacora.ExecuteNonQuery();
                conectado.Close();


            }
            catch (Exception)
            {

            }
        }

        public void consultarBitacora(DTOBitacora bitacora)
        {
            try
            {



            }
            catch
            {
            }

        }
    }
}