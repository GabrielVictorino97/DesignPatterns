using System;

namespace Adapter
{
    class PayonnerAdapter : IPaypalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Realizando adaptação de Payonner para Paypal");
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
