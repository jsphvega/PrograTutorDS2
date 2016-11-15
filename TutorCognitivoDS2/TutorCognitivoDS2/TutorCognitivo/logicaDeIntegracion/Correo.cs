using System;
using System.Net.Mail;

namespace logicaDeIntegracion
{
    public class Correo : ICorreo
    {
        private String asunto;
        private String cuerpoCorreo;
        private String correo;

        public Correo(String pAsunto, String pCuerpoCorreo, String pCorreo)
        {
            asunto = pAsunto;
            cuerpoCorreo = pCuerpoCorreo;
            correo = pCorreo;
        }

        public void enviarCorreo()
        {
            if (String.IsNullOrEmpty(correo))
                return;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("tutorcognitivo4@gmail.com", "Tutor Cognitivo by ChukyBueno");
                mail.Subject = asunto;

                mail.Body = cuerpoCorreo;

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     ("tutorcognitivo4@gmail.com", "chukyBueno4"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception)
            {
            }
        }
    }
}