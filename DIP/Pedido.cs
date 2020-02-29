using System;
namespace DIP
{
    public class Pedido
    {
        private IFormaPagamento forma;
        public void pagar(){

            forma.pagar();
        }

        //inversao de conttrole
        public Pedido(IFormaPagamento forma)
        {
            this.forma = forma;
        }
    }
}