using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    class YouTube : IPlataform
    {

        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP.");
        }
    }
}
