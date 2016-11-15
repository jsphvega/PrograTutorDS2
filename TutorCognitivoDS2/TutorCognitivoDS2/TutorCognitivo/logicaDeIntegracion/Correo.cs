using System;

namespace logicaDeIntegracion
{
    public class Correo : ICorreo
    {
        private String asunto;
        private String cuerpoCorreo;
        private String correo;

        public Correo(String pAsunto, String pCuerpoCorreo, String pCorreo)
        {
        }

        public void enviarCorreo()
        {
        }

    }
}