using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new CartaoCredito());
            pedido.pagar();
        }
    }
}
