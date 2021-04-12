using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@gabriel.com.br"))
            {
                Console.WriteLine("Seja bem-vendo Administrador!");
                return true;
            }

            Console.WriteLine("Seja bem-vindo!");

            return CheckNext(email, password);
        }
    }
}
