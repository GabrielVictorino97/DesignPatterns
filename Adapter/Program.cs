using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            IPaypalPayment payment = new PayonnerAdapter(new Payonner());
            IPaypalPayment pagamento = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.WriteLine("");

            pagamento.PayPalPayment();
            pagamento.PayPalReceive();

            Console.ReadLine();

        }
    }
}
