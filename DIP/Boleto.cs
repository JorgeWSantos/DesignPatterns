using System;

namespace DIP
{
    public class Boleto : IFormaPagamento
    {
        public void pagar(){

            Console.WriteLine("Pagar boleto.");
        }
    }
}