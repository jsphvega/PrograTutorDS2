
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaDeNegocios{
    /**
     * 
     */
    public abstract class Usuario {


        /**
         * 
         */
        String nombre;

        /**
         * 
         */
        String correo;

        /**
         * 
         */
        String contraseña;

        /**
         * 
         */
        String carrera;

        /**
         * @param pNombre 
         * @param pCorreo 
         * @param pContraseña 
         * @param pCarrera
         */
        public Usuario(String pNombre, String pCorreo, String pContraseña, String pCarrera) {
            // TODO implement here
        }

        /**
         * @return
         */
        public abstract void registrarUsuario();

        /**
         * @return
         */
        public abstract String toString();

    }
}