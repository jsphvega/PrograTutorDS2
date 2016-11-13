
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaDeNegocios{
    /**
     * 
     */
    public abstract class Registro {

        /**
         * 
         */
        public Registro() {
        }

        /**
         * 
         */
        private DateTime fecha;

        /**
         * 
         */
        private DateTime hora;

        /**
         * 
         */
        private String tipoAccion;

        /**
         * 
         */
        private String accion;

        /**
         * 
         */
        private Bitacora registro;

        /**
         * @param tipoAccion 
         * @param accion
         */
        public void RegistroBitacora(String tipoAccion, String accion) {
            // TODO implement here
        }

        /**
         * @param pFecha 
         * @return
         */
        public void setFecha(DateTime pFecha) {
            // TODO implement here
        }

        /**
         * @param pHora 
         * @return
         */
        public void setHora(DateTime pHora) {
            // TODO implement here
        }

        /**
         * @param pTipo 
         * @return
         */
        public void setTipoAccion(String pTipo) {
            // TODO implement here
        }

        /**
         * @param pAccion 
         * @return
         */
        public void setAccion(String pAccion) {
            // TODO implement here
        }

        /**
         * @return
         */
        public DateTime getFecha() {
            // TODO implement here
            return new DateTime();
        }

        /**
         * @return
         */
        public DateTime getHora() {
            // TODO implement here
            return new DateTime();
        }

        /**
         * @return
         */
        public String getTipoAccion() {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public String getAccion() {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        protected void notificarATodos() {
            // TODO implement here
        }

        /**
         * @param Bitacora 
         * @return
         */
        public abstract void añadir(Bitacora Bitacora);

        /**
         * @param Bitacora 
         * @return
         */
        public abstract void eliminar(Bitacora Bitacora);

    }
}