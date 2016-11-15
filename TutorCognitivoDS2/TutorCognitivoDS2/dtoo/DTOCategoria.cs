using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorCognitivoDS2.DTO
{
    //clase que corresponde al DTO de Categoria
    public class DTOCategoria
    {
        private String nombre;

        public DTOCategoria(String pNombre)
        {
            nombre = pNombre;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}