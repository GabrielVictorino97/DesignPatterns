using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    class TheLive : IPlataform
    {
        public TheLive()
        {
            ConfigureRMTP();
            Console.WriteLine("TheLive: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("TheLive: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TheLive: Configurando servidor RMTP.");
        }
    }
}
