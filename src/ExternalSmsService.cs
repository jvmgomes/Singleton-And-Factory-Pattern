using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public class ExternalSmsService
    {
        public void sendText(string msg)
        {
            Console.WriteLine("SMS externo: " + msg);
        }
    }
}