using System;

namespace logicaDeNegocios
{
    public abstract class Registro
    {

        private DateTime fecha;
        private DateTime hora;
        private String tipoAccion;
        private String accion;
        private Bitacora registro;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string TipoAccion
        {
            get { return tipoAccion; }
            set { tipoAccion = value; }
        }

        public string Accion
        {
            get { return accion; }
            set { accion = value; }
        }

        public void RegistroBitacora(String tipoAccion, String accion)
        {
            // TODO implement here
        }

        protected void notificarATodos()
        {
            // TODO implement here
        }

        public abstract void añadir(Bitacora Bitacora);

        public abstract void eliminar(Bitacora Bitacora);

    }
}