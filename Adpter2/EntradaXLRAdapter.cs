using System;
namespace adpter2
{
    //adapter
    public class EntradaXLRAdapter : EntradaXLR
    {
        private EntradaP10 p10;

        public EntradaXLRAdapter(EntradaP10 p10)
        {
            this.p10 = p10;
        }

        public override void conectarXLR(){

            Console.WriteLine("convert xlr para");
            p10.conectarP10();
        }
    }
}