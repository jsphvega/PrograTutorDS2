using System;

namespace logicaDeNegocios
{
    public abstract class Registro
    {
        private DateTime fecha;
        private String accion;
        private Bitacora registro;

        public void RegistroBitacora(String tipoAccion, String accion)
        { 
            this.fecha= DateTime.Today;
            this.accion = tipoAccion;
            this.accion = accion;
            
        }

        public String  Accion
        {
            get { return accion; }
            set {accion = value; }
        }

        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public void notificarATodos()
        {

        }

        public abstract void añadir(Bitacora bitacora);

        public abstract void eliminar(Bitacora bitacora);
    }
}