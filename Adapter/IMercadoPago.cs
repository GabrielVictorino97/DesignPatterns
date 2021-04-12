
namespace Adapter
{
    interface IMercadoPago
    {
        Token AuthToken();
        void SendPagamento();
        void ReceivePagamento();
    }
}
