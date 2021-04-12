using Chain.Middlewares;
using Chain.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@gabriel.com.br", "1234");

            server.RegisterUser("user@gabriel.com.br", "123");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {

            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite seu e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            } while (!done);


            Console.ReadLine();
        }
    }
}
