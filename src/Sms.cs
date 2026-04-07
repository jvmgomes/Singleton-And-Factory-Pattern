using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class Sms : Notification
    {
        public void send(string message)
        {
            Console.WriteLine("Enviando SMS: " + message);
        }
    }
}
