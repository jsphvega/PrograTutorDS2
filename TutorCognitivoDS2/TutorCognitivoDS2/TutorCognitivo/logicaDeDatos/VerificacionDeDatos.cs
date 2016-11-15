using dto;
using MySql.Data.MySqlClient;
using System;

namespace logicaDeDatos
{
    public class VerificacionDeDatos : ConexionBD
    {
        private MySqlCommand comando;
        private String conection;
        private MySqlConnection conectado;
        private MySqlDataReader lectura;

        //metodo que permite la conexion con la base remota
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

        public bool verificarInicioSesion(DTOInicioSesion inicioSesion)
        {
            conectarBD();
            conectado.Open();
            comando = new MySqlCommand();
            comando.Connection = conectado;
            comando.CommandText = "Select Correo,Contraseņa,Tipo from usuario";
            lectura = comando.ExecuteReader();
            lectura.Read();
            while (lectura.Read())
            {
                string correo = "";

                string contraseņa = "";
                int tipo = 0;

                correo = lectura.ToString();

                contraseņa = lectura.ToString();
                tipo = Int32.Parse(lectura.ToString());


                if (correo == inicioSesion.Correo & contraseņa == inicioSesion.Contraseņa & tipo == inicioSesion.Tipo)
                {
                    return true;
                }

            }
            conectado.Close();
            return false;
        }




        //verifica el correo del usuario en la BD 
        public bool verificarCorreo(String pCorreo)
        {

            conectarBD();
            conectado.Open();
            comando = new MySqlCommand();
            comando.Connection = conectado;
            comando.CommandText = "Select Correo from usuario";
            lectura = comando.ExecuteReader();
            while (lectura.Read())
            {

                string correo = "";
                correo = lectura.ToString();

                if (pCorreo == correo)
                {
                    return true;
                }
            }

            conectado.Close();
            return false;
        }


        //metodo que verifica que existe un usuario en la BD
        public bool verificarUsuarioExistente(DTOUsuario usuario)
        {
            conectarBD();
            conectado.Open();
            comando = new MySqlCommand();
            comando.Connection = conectado;
            comando.CommandText = "Select Nombre,Apellido1,Apellido2,Correo,Contraseņa,Tipo from usuario";
            lectura = comando.ExecuteReader();
            lectura.Read();
            while (lectura.Read())
            {
                string nombre = "";

                string apellido1 = "";
                string apellido2 = "";
                string correo = "";
                string contraseņa = "";
                string tipo = "";

                nombre = lectura.ToString();
                apellido1 = lectura.ToString();
                apellido2 = lectura.ToString();
                correo = lectura.ToString();
                contraseņa = lectura.ToString();
                tipo = lectura.ToString();
                if (nombre == usuario.Nombre & apellido1 == usuario.Apellido1 & apellido2 == usuario.Apellido2 & usuario.Correo == correo & contraseņa == usuario.Contraseņa1)
                {
                    return true;
                }

            }

            conectado.Close();
            return false;
        }

    }
}