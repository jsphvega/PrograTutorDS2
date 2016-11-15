using System.Collections;
using System.Collections.Generic;

namespace logicaDeNegocios
{
    public abstract class Bitacora
    {

        public Bitacora()
        {
        }

        private ArrayList bitacoras;

        public abstract void actualizar();

    }
}