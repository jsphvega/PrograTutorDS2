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
            comando.CommandText = "Select correo,contraseña,tipo from usuario";
            lectura = comando.ExecuteReader();
            lectura.Read();
            while (lectura.Read())
            {
                string correo = "";

                string contraseña = "";
                int tipo = 0;

                correo = lectura.GetValue(4).ToString();

                contraseña = lectura.GetValue(5).ToString();

                tipo = Int32.Parse(lectura.GetValue(6).ToString());


                if (correo == inicioSesion.Correo & contraseña == inicioSesion.Contraseña & tipo == inicioSesion.Tipo)
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
            comando.CommandText = "Select * from usuario";
            lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                string Correo = lectura.GetValue(4).ToString();

                if (pCorreo == Correo)
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
            comando.CommandText = "Select nombre,apellido1,apellido2,correo,contrasena,tipo from usuario";
            lectura = comando.ExecuteReader();
            lectura.Read();
            while (lectura.Read())
            {
                string nombre = "";

                string apellido1 = "";
                string apellido2 = "";
                string correo = "";
                string contraseña = "";
                string tipo = "";

                nombre = lectura.GetValue(1).ToString();
                apellido1 = lectura.GetValue(2).ToString();
                apellido2 = lectura.GetValue(3).ToString();
                correo = lectura.GetValue(4).ToString();
                contraseña = lectura.GetValue(5).ToString();
                tipo = lectura.GetValue(6).ToString();

                if (nombre == usuario.Nombre & apellido1 == usuario.Apellido1 & apellido2 == usuario.Apellido2 & usuario.Correo == correo & contraseña == usuario.Contraseña1)
                {
                    return true;
                }

            }

            conectado.Close();
            return false;
        }

    }
}