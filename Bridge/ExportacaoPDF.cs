using System;

namespace bridge
{
    //concrete implementor
    public class ExportacaoPDF : ImplementorExportar
    {
        public override void Exportar(){

            Console.WriteLine("Executar pdf");
        }
    }
}