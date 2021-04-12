using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123"))
            {
                Console.WriteLine("ATENÇÃO: Considere usar uma senha mais segura!");
            }

            return CheckNext(email, password);
        }
    }
}
