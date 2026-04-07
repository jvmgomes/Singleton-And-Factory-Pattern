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
            switch(value.ToLower())
            {
                case "email":
                    return new Email();
                case "push":
                    return new Push();
                case "sms":
                    return new Sms();
                default:
                    throw new ArgumentException("Tipo de Notificação Inválido");
            }
        }
    }
}
