using Chain.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido!");
                return false;
            }

            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("E-mail e/ou Senha Inválidos!");
                return false;
            }

            return CheckNext(email, password);

        }
    }
}
