using controlador;
using dto;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorCognitivoDS2.TutorCognitivo.dto;
using validacion;

namespace TutorCognitivoDS2.vista
{
    public partial class ConfirmarTutor : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            DTOConfirmacion sConfirmacion = new DTOConfirmacion(txtContraseña1.Text, txtContraseña2.Text);

            lblError.Text = Validacion.validarConfirmacion(sConfirmacion);

            if (lblError.Text == String.Empty)
            {
                //Cambiar la contraseña
                Response.Redirect("MainTutor.aspx");
                //controlador.mensajeInterfaz("Datos reemplazados correctamente");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Response.BufferOutput = true;
                Response.Redirect("Login.aspx");
            }
        }
    }
}