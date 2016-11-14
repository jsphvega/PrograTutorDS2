using dto;
using TutorCognitivoDS2.accesoADatos;

namespace controlador
{
    public class Controlador
    {
        private AdapterJava adaptador;

        public Controlador()
        {

        }

        public void insertarUsuarioFinal()
        {
            DTOUsuario dto = new DTOUsuario("Joseph", "Vega", "Vargas", "j-vv01@hotmail.com", "12345", "12");

            DatoUsuario DU = new DatoUsuario();
            DU.registrarUsuario(dto);
        }
    }
}