using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ServiciosMail
{
    class SistemaSoportMail:Mail
    {
        //Creamos el constructor

        public SistemaSoportMail()
        {
            senderMail = "soportealturapolar@gmail.com";
            password = "najcbhzukbcdyzql";
            host = "smtp.gmail.com";
            portl = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
