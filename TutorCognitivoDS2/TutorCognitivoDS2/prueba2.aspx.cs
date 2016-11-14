using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorCognitivoDS2.accesoADatos;

namespace TutorCognitivoDS2
{
    public partial class prueba2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatoInicioSesion dato = new DatoInicioSesion();
            
            if (dato.verificarInicioSesion("hola", "maria")== true)
            {
                Response.Write("se encuentra en la base");
            }
            else
            {
                Response.Write("no se encuentra en la base");
            }

}

    }