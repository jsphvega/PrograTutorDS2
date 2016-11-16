using System;
using System.Collections.Generic;

namespace logicaDeNegocios
{
    public abstract class Registro
    {
        private DateTime fecha;
        private String accion;

        List<Bitacora[]> bitacora;

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


        private void notificarATodos()
        {
         
        }

        public abstract void añadir(Bitacora bitacora);

       
    }
}