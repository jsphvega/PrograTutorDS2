using controlador;
using dto;
using System;
using TutorCognitivoDS2.validacion;

namespace TutorCognitivoDS2.Vista
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnCancelar.Attributes["Onclick"] = "return confirm('¿Está seguro? Se perderán los datos')";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            DTOUsuario sUsuario = new DTOUsuario(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                txtCorreo.Text, txtContraseña1.Text, txtContraseña2.Text, Int32.Parse(ddlCarrera.DataValueField));

            lblError.Text = Validacion.validarUsuario(sUsuario);

            if (lblError.Text != String.Empty)
            {
                Controlador controlador = new Controlador();
                controlador.insertarUsuarioFinal(sUsuario);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Response.BufferOutput = true;
                Response.Redirect("login.aspx");
            }
        }
    }
}