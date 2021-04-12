using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayPal : IPaypalPayment
    {

        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
