using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorCognitivoDS2.DTO
{
    //clase que corresponde al DTO de Curso
    public class DTOCurso
    {

        private String nombre;

        public DTOCurso(String pNombre)
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