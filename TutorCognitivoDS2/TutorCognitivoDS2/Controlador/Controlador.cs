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

        public void insertarUsuarioFinal(DTOUsuario dto)
        {
            DatoUsuario DU = new DatoUsuario();
            DU.registrarUsuario(dto);
        }
    }
}