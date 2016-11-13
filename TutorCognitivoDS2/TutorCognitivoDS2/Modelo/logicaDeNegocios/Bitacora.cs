
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaDeNegocios{
    /**
     * 
     */
    public abstract abstract class Bitacora {

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