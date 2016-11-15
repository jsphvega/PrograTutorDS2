using System;

namespace logicaDeNegocios
{
    public abstract class Registro
    {
        private DateTime fecha;
        private String tipoAccion;
        private String accion;
        private Bitacora registro;

        public void RegistroBitacora(String tipoAccion, String accion)
        {
        }

        protected void notificarATodos()
        {
        }

        public abstract void añadir(Bitacora bitacora);

        public abstract void eliminar(Bitacora bitacora);
    }
}