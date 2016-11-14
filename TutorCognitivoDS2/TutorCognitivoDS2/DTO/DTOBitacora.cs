using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorCognitivoDS2.DTO
{
    //clase que corresponde al DTO de bitacora
    public class DTOBitacora
    {
        private DateTime fechaHora;
        private String accion;
        private String contraseña;
         
        public DTOBitacora(DateTime pFechaHora, String pAccion, String pContraseña)
        {
            fechaHora = pFechaHora;
            accion = pAccion;
            contraseña = pContraseña;
        }

        public DateTime FechaHora
        {
            get
            {
                return fechaHora;
            }
            set
            {
                fechaHora= value;
            }
        }

        public String Accion
        {
            get
            {
                return accion;
            }
            set
            {
               accion = value;
            }
        }

        public String Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }

    }
}