using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago : IMercadoPago
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePagamento()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com MercadoPago");
        }

        public void SendPagamento()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com MercadoPago");
        }
    }
}
