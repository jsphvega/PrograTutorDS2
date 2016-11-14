using dto;
using TutorCognitivoDS2.accesoADatos;
using MySql.Data.MySqlClient;

namespace controlador
{
    public class Controlador
    {
        private AdapterJava adaptador;

        public Controlador()
        {

        }

        public void insertarUsuarioFinal(DTOUsuario dto)
        {
            DatoUsuario DU = new DatoUsuario();
            DU.registrarUsuario(dto);
        }
    }
}