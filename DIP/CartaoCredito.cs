using System;

namespace DIP
{
    public class CartaoCredito : IFormaPagamento
    {
        public void pagar(){

            Console.WriteLine("Pagar cartão de crédito.");
        }
    }
}