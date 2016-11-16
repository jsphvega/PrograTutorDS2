using controlador;
using dto;
using System;
using System.Web.UI;
using validacion;

namespace TutorCognitivoDS2.Vista
{
    public partial class login : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            //try
            //{
                DTOInicioSesion sSesion = new DTOInicioSesion(txtUsuario.Text, txtContraseña.Text, 3);
                lblError.Text = Validacion.validarSesion(sSesion);

                if (lblError.Text == String.Empty)
                {
                    if (controlador.verificarSesion(sSesion))
                    {
                        if (rdnAdmin.Checked)
                        {
                            Response.BufferOutput = true;
                            Response.Redirect("MainAdmin.aspx");
                        }
                        else if (rdnTutor.Checked)
                        {
                            Response.BufferOutput = true;
                            if (sSesion.Contraseña.Equals("tutortutor"))
                                Response.Redirect("ConfirmarTutor.aspx");
                            else
                                Response.Redirect("MainTutor.aspx");
                        }
                        else
                        {
                            Response.BufferOutput = true;
                            Response.Redirect("MainFinal.aspx");
                        }
                    }
                    else
                    {
                        mensajeInterfaz("Usuario o contraseña incorrectos");
                    }
                }
            //}
            //catch
            //{
            //    mensajeInterfaz("Error al realizar la consulta");
            //}
        }

        public void mensajeInterfaz(String pMensaje)
        {
            string script = @"<script type='text/javascript'>alert('" + pMensaje + "');</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);
        }
    }
}