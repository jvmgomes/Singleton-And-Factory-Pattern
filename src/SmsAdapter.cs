using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class SmsAdapter : Notification
    {
        private ExternalSmsService external = new ExternalSmsService();

        public void send(string message) // adapter
        {
            external.sendText(message);
        }
    }
}