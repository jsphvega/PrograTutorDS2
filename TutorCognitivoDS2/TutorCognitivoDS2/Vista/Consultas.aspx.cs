using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorCognitivoDS2.vista
{
    public partial class Consultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBitacora.Visible = false;
            panelBitacora.Visible = false;
            panelBitacora.Visible = false;

            if (ddlConsulta.SelectedIndex == 1)
                panelBitacora.Visible = true;
            else if (ddlConsulta.SelectedIndex == 2)
                panelBitacora.Visible = true;
            if (ddlConsulta.SelectedIndex == 3)
                panelBitacora.Visible = true;
        }
    }
}