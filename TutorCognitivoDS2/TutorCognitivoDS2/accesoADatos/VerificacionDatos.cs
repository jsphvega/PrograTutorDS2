using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using TutorCognitivoDS2.DTO;
using dto;

namespace TutorCognitivoDS2.accesoADatos
{
    //esta clase verfica los datos que ingresa el usuario
    public class VerificacionDatos
    {
        private MySqlCommand comando;
        private string conection;
        private MySqlConnection conectar;
        MySqlDataReader lectura;


        //metodo que permite la conexion con la base remota
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

        //metodo que verifica que los datos que se ingresan al iniciar sesion correspondan a los almacenados en la BD
        public bool verificarInicioSesion(DTOInicioSesion inicioSesion ,String pTipo)
        {
            conectarBD();
            conectar.Open();
            comando = new MySqlCommand();
            comando.Connection = conectar;
            comando.CommandText = "Select Correo,Contraseña,Tipo from usuario";
            lectura = comando.ExecuteReader();
            lectura.Read();
            while(lectura.Read())
           {
                string correo = "";

                string contraseña = "";
                string tipo = "";

               correo= lectura.ToString();

               contraseña = lectura.ToString();
               tipo = lectura.ToString();

              
                if (correo == inicioSesion.Correo & contraseña== inicioSesion.Contraseña & tipo== pTipo)
                {
                 return true;  
               }

           }
          
            conectar.Close();
            return false;
        }

        //metodo que verifica que existe un usuario en la BD
        public bool verificarUsuarioExistente(DTOUsuario usuario)
        {
            conectarBD();
            conectar.Open();
            comando = new MySqlCommand();
            comando.Connection = conectar;
            comando.CommandText = "Select Nombre,Apellido1,Apellido2,Correo,Contraseña,Tipo from usuario";
            lectura = comando.ExecuteReader();
            lectura.Read();
            while (lectura.Read())
            {
                string nombre = "";

                string apellido1 = "";
                string apellido2 = "";
                string correo = "";
                string contraseña= "";
                string tipo = "";

                nombre = lectura.ToString();
                apellido1= lectura.ToString();
                apellido2= lectura.ToString();
                correo = lectura.ToString();
                contraseña = lectura.ToString();
                tipo = lectura.ToString();


                if (nombre== usuario.Nombre & apellido1 == usuario.Apellido1 & apellido2 == usuario.Apellido2 & usuario.Correo == correo & contraseña == usuario.Contraseña1 )
                {
                    return true;
                }

            }

            conectar.Close();
            return false;
        }





    }
}