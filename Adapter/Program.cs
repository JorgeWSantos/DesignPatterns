using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            target.request();
            // Target target_adaptee = new Adaptee(); não são compativeis
            Target adptado = new Adapter();//tornando-os compativeis
            adptado.request();
        }
    }
}
