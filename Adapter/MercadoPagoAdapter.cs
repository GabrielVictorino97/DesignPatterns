using System;

namespace Adapter
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação de MercadoPago para Paypal");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.SendPagamento();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.ReceivePagamento();
        }
    }
}
