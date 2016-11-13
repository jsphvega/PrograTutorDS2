
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaIntegracion{
    /**
     * 
     */
    public interface Correo {

        /**
         * @return
         */
        public void configurarCorreo();

        /**
         * @return
         */
        public void enviarCorreo();

    }
}