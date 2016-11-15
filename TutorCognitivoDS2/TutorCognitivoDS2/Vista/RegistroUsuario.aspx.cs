using controlador;
using dto;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using validacion;

namespace TutorCognitivoDS2.vista
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<String[]> pLista = controlador.obtenerListaCarreras();

                for (int i = 0; i < pLista.Count; i++)
                {
                    ListItem item = new ListItem(pLista[i][1].ToString(), pLista[i][0].ToString());
                    ddlCarrera.Items.Add(item);
                }

                btnCancelar.Attributes["Onclick"] = "return confirm('¿Está seguro? Se perderán los datos')";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            DTOUsuario sUsuario = new DTOUsuario(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                txtCorreo.Text, txtContraseña1.Text, txtContraseña2.Text, Int32.Parse(ddlCarrera.SelectedValue));

            lblError.Text = Validacion.validarUsuario(sUsuario);

            if (lblError.Text == String.Empty)
            {
                controlador.insertarUsuarioFinal(sUsuario);
                Response.Redirect("Login.aspx");
                controlador.mensaje("Datos insertados correctamente");
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