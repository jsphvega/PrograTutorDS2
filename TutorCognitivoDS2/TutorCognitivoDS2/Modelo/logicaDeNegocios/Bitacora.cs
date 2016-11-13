
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaDeNegocios{
    /**
     * 
     */
    public abstract class Bitacora {

        /**
         * 
         */
        public Bitacora() {
        }

        /**
         * 
         */
        private HashSet<Registro> bitacoras;

        /**
         * @return
         */
        public abstract void actualizar();

    }
}