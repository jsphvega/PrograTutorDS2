using dto;
using logicaDeDatos;

namespace controlador
{
    public class Controlador
    {
        private AdapterJava adaptador;

        public void insertarUsuarioFinal(DTOUsuario dto)
        {
            DatoUsuario DU = new DatoUsuario();
            DU.registrarUsuario(dto);
        }
    }
}