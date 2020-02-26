using System;

namespace bridge
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Exportacao exp = new ExportacaoEx();
            //injetando objeto de implementação
            exp.setImplementor = new ExportacaoDOC();
            exp.Exportar();
        }
    }
}
