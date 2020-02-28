using System;

namespace adpter2
{
    public class EntradaTRSAdapter : EntradaTRS
    {
        private EntradaP10 p10;

        public EntradaTRSAdapter(EntradaP10 p10){

            this.p10 = p10;
        }

        public override void conectarTRS(){

            Console.WriteLine("convert trs para");
            p10.conectarP10();
        }
    }
}