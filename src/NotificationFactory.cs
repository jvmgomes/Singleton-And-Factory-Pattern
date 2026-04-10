using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class NotificationFactory
    {
        public static Notification Create(string value)
        {
            Notification notification;

            switch(value.ToLower())
            {
                case "email":
                    notification = new Email();
                    break;
                case "push":
                    notification = new Push();
                    break;
                case "sms":
                    notification = new SmsAdapter();
                    break;

                default:
                    throw new ArgumentException("Tipo de Notificação Inválido");
            }
            
            return new NotificationProxy(notification); // proxy
        }
    }
}
