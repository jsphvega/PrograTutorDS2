using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TutorCognitivoDS2.accesoADatos
{
    public class RegistroUsuario
       
    {
    private ConexionBD conexion;
    private MySqlCommand comando;

        public void registrarTutor()
        {
            conexion = new ConexionBD();
            conexion.conectarBD();
            conexion.abrirConexion();
            comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO carrera(Nombre) VALUES(@Nombre)";


        }
}
}