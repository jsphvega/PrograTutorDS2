using System;
using System.Collections;
using System.Collections.Generic;

namespace logicaDeNegocios
{
    public class Curso
    {

        private String codigo;
        private String nombre;
        private ArrayList categorias;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Curso(int pCodigo, String pNombre)
        {
            // TODO implement here
        }

        public String toString()
        {
            // TODO implement here
            return null;
        }

    }
}