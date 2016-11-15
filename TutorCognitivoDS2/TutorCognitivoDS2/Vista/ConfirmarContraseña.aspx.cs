using controlador;
using System;
using TutorCognitivoDS2.TutorCognitivo.dto;
using validacion;

namespace TutorCognitivoDS2.vista
{
    public partial class ConfirmarContraseña : System.Web.UI.Page
    {
        Controlador controlador;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            DTOConfirmacion sConfirmacion = new DTOConfirmacion(txtContraseña1.Text, txtContraseña2.Text);

            lblError.Text = Validacion.validarConfirmacion(sConfirmacion);

            if (lblError.Text == String.Empty)
            {
                //Cambiar la contraseña
                Response.Redirect("MainTutor.aspx");
                controlador.mensaje("Datos reemplazados correctamente");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Response.BufferOutput = true;

            }
        }
    }
}