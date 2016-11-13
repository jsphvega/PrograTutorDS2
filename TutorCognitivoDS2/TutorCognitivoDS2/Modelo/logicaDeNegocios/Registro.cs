
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaDeNegocios{
    /**
     * 
     */
    public abstract abstract class Registro {

        /**
         * 
         */
        public Registro() {
        }

        /**
         * 
         */
        private Date fecha;

        /**
         * 
         */
        private Date hora;

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
        public void setFecha(Date pFecha) {
            // TODO implement here
            return null;
        }

        /**
         * @param pHora 
         * @return
         */
        public void setHora(Date pHora) {
            // TODO implement here
            return null;
        }

        /**
         * @param pTipo 
         * @return
         */
        public void setTipoAccion(String pTipo) {
            // TODO implement here
            return null;
        }

        /**
         * @param pAccion 
         * @return
         */
        public void setAccion(String pAccion) {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public Date getFecha() {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public Date getHora() {
            // TODO implement here
            return null;
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
            return null;
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