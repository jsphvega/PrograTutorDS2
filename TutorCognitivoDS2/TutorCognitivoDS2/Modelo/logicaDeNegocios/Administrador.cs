using dto;

namespace logicaDeNegocios
{
    public class Administrador : DecoradorAdministrador
    {
        private DecoradorAdministrador decorador;

        public Administrador(DTOUsuario pUsuario)
        {
            decorador = new DecoradorAdministrador(DTOUsuario pUsuario);
        }

        public void registrarCurso(Curso pCurso)
        {
            // TODO implement here
        }

        public void registrarCategoria(Categoria pCategoria)
        {
            // TODO implement here
        }

        public void consultarBitacora()
        {
            // TODO implement here
        }

    }
}