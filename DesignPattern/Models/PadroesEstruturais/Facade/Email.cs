using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    // Façade
    public class Email
    {
        private Mail _mail;
        private MailFormat _format;
        private SMTPSettings _conf;
        private MailMessage _msg;

        public Email()
        {
            this._conf = new SMTPSettings()
            {
                ServerName = "smtp.gmail.com",
                Password = "123",
                UserName = "default"
            };
            this._mail = new Mail(_conf);
            this._format = new MailFormatTXT(); 
            this._msg = new MailMessage("", _format);

        }

        public string Enviar(string Mensagem)
        {
            _msg.Message = Mensagem;
            return _mail.Send(_msg);
        }
    }
}
