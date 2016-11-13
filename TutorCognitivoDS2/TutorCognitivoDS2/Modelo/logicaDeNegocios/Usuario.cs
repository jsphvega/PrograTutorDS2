
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logicaDeNegocios{
    /**
     * 
     */
    public abstract abstract class Usuario {

        /**
         * 
         */
        public Usuario() {
        }

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
        public void Usuario(String pNombre, String pCorreo, String pContraseña, String pCarrera) {
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