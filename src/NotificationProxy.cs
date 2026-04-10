using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class NotificationProxy : Notification
    {
        private Notification realNotification;
        private int tries = 0; // contador de tentativas

        public NotificationProxy(Notification notification)
        {
            realNotification = notification;
        }

        public void send(string message)
        {
            var config = GlobalConfiguration.getInstance();

            if (tries >= config.MaxTries)
            {
                Console.WriteLine("Limite atingido"); //limitador de tentativas
                return;
            }

            Console.WriteLine("Log: enviando mensagem..."); //simulando logs
            tries++;

            realNotification.send(message);
        }
    }
}