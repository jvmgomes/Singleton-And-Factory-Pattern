using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    internal class GlobalConfiguration
    {
        private static GlobalConfiguration instance;

        public string ApplicationName { get; set; }
        public string SenderServer { get; set; }

        public int MaxTries { get; set; }

        private GlobalConfiguration()
        {  // configurações padrão
            ApplicationName = "Google 2.0";
            SenderServer = "google2.com";
            MaxTries = 5;
        }



        public static GlobalConfiguration getInstance() // método para obter a instância única da classe
        {
            if (instance == null)
            {
                instance = new GlobalConfiguration(); // cria se ainda não existir
            }
            return instance;
        }

    }

}
