using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ServiciosMail
{
    //Esta clase  se va encargar  de enviar cualquier correo electronico a uno o varios correos.
    /*
     * Este clase es abstract ya que no se desea que pueda ser instanciada, 
     *tambien se le conoce como clase base que puede ser consumida directamente o mediante la herencia
     */
    public abstract class Mail
    {
        //Declaro atributos privados
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int portl { get; set; }
        protected bool ssl { get; set; }

        //Creamos un metodo protegido para inicializar el cliente
        protected void initializeSmtpClient()
        {
            //Instanciamos el smtpClient

            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = portl;
            smtpClient.EnableSsl = ssl;
        }
        //Creamos un metodo publico para enviar  mensajes de correo
        //El  List<string> recipientMail permite enviar correo a uno o mas personas.
        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                //Construimos el mensaje
                mailMessage.From = new MailAddress(senderMail);                         //Indicamos de quien es enviado el correo.

                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);                                                            // Indicamos para quien es enviado el mensaje.
                }

                mailMessage.Subject = subject;                                                        //Especificamos el asunto del correo 
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;                                    //Indicamos la prioridad del correo.
                smtpClient.Send(mailMessage);

            }
            catch (Exception)
            {

            }
            finally
            {
                //Liberamos los recursos creados
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
