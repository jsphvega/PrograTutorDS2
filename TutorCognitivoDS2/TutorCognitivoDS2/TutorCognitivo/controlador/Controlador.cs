using dto;
using logicaDeDatos;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace controlador
{
    public class Controlador
    {
        private AdapterJava adaptador;

        public DropDownList rellenarListaCarreras()
        {
            DatoCarrera dc = new DatoCarrera();
            List<String[]> lista = dc.Consulta();

            DropDownList ddlLista = new DropDownList();
            for (int i = 0; i < lista.Count; i++)
            {
                ListItem ld = new ListItem(lista[i][0].ToString(), lista[i][1].ToString());
                ddlLista.Items.Add(ld);
            }

            return ddlLista;
        }

        public void insertarUsuarioFinal(DTOUsuario dto)
        {
            DatoUsuario DU = new DatoUsuario();
            DU.registrarUsuario(dto);

        }

        public void enviarCorreoCategoria()
        {


        }

        public void enviarCorreoConsulta()
        {


        }

    }
}