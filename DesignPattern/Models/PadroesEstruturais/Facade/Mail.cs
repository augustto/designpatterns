using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Mail
    {
        private SMTPSettings _conf;

        public Mail(SMTPSettings conf)
        {
            this._conf = conf;
        }

        public string Send(MailMessage message)
        {
            // usando configurações SMTP
            string msg = "Enviando mensagem...";
            msg += "<br>" +  message.Message;

            return msg;
        }
    }
}
