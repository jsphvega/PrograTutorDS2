using System;

namespace TutorCognitivoDS2.Vista
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("http://www.microsoft.com/gohere/look.htm");

            //Response.Write("<script>window.alert('Imposible generar medios');</script>");
        }
    }
}