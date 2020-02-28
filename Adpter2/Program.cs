using System;

namespace adpter2
{
    class Program
    {
        static void Main(string[] args)
        {
            EntradaP10 p10 = new EntradaP10();
            EntradaXLRAdapter adapterXlr = new EntradaXLRAdapter(p10);
            adapterXlr.conectarXLR();

            EntradaTRSAdapter adapterTRS = new EntradaTRSAdapter(p10);
            adapterTRS.conectarTRS();

        }
    }
}
