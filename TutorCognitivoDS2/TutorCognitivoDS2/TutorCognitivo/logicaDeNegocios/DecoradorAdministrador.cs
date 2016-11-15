using dto;

namespace logicaDeNegocios
{
    public class DecoradorAdministrador : Administrador
    {
        public Administrador administrador;

        public DecoradorAdministrador(DTOUsuario pUsuario)
            : base(pUsuario)
        {
            administrador = new Administrador(pUsuario);
        }

        public void registrarCurso(Curso DTOCurso)
        {
        }

        public void registrarCategoria(Categoria DTOCategoria)
        {
        }

        public void consultarBitacora()
        {
        }

        public void consultarTutores()
        {
        }

        public void consultarTutor(DTOUsuario usuario)
        {
        }

    }
}