using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class Push : Notification
    {
        public void send(string message)
        {
            Console.WriteLine("Enviando Notificação Push: " + message);
        }
    }
}
