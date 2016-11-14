using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using TutorCognitivoDS2.DTO;

namespace TutorCognitivoDS2.accesoADatos
{
    public class DatoCategoria
    {
        private MySqlCommand comandoCategoria;
        private string coneccion;
        private MySqlConnection comandoConectar;
        private MySqlDataReader consultaCategoria;

        public void conectarBD()
        {
            try
            {
                coneccion = "Server = us-cdbr-iron-east-04.cleardb.net;database = ad_699a080b2007672;uid =b4d3a4bbc609bd;password =2b616b93;SslMode=None;";
                comandoConectar = new MySqlConnection(coneccion);
            }
            catch (Exception)
            {

            }
        }

        public void registrarCategoria(DTOCategoria categoria)
        {
            try
            {
                conectarBD();
                comandoConectar.Open();
                comandoCategoria = new MySqlCommand();
                comandoCategoria.Connection = comandoConectar;
                comandoCategoria.CommandText = "INSERT INTO categoria(Nombre) VALUES(@Nombre)";
                comandoCategoria.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                comandoCategoria.ExecuteNonQuery();
                comandoConectar.Close();


            }
            catch (Exception)
            {

            }

        }


        public void consultarCategoria(DTOCategoria categoria)
        {


        }
}
}