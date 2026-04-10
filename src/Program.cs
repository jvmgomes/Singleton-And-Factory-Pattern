using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class Test
    {
        static void Main(string[] args)
        {
            //funcionamento da Singleton

            var config1 = GlobalConfiguration.getInstance();
            var config2 = GlobalConfiguration.getInstance();

            if (config1 == config2)
            {
                Console.WriteLine("As configurações são as mesmas, pois são a mesma instância."); 
            }

            Console.WriteLine(config1.ApplicationName);
            Console.WriteLine(config1.SenderServer);

            // -------------
            //funcionamento da fábrica

            Notification email = NotificationFactory.Create("email");
            email.send("Você recebeu um email!");

            Notification sms = NotificationFactory.Create("SMS"); 
            sms.send("Seu código é: 1357");

            Notification push = NotificationFactory.Create("PuSh");
            push.send("Notificação Pintando na Área");

            // ---------------
            // funcionamento do proxy e adapter

            var n = NotificationFactory.Create("sms");
            n.send("teste");

        }
    }
}
