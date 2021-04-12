using System;

namespace Bridge.Plataforms
{
    class Facebook : IPlataform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP.");
        }
    }
}
