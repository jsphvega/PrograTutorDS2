using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using frameworkJava.logicaDeIntegracion;

namespace tutorCognitivo1.Models.logicaDeNegocios
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Traductor traductor = new Traductor();
            System.Console.WriteLine(traductor.traducirTexto("hola"));

        }


    }
}