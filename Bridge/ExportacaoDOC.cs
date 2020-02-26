using System;

namespace bridge
{
    //concrete implementor
    public class ExportacaoDOC : ImplementorExportar
    {
        public override void Exportar() {
            
            Console.WriteLine("Executar doc");
        }
    }
}