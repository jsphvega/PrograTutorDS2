using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace TutorCognitivoDS2.integracion
{
    public class Correo:ICorreo
    {
        String asunto;
        String cuerpoCorreo;
        String correo;

        //metodo constructor de la clase 

        public Correo(String pAsunto, String pCuerpoCorreo, String pCorreo)
        {
            asunto = pAsunto;
            cuerpoCorreo = pCuerpoCorreo;
            correo = pCorreo;
        }

        //metodo para enviar el correo
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