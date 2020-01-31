using System;

namespace DesignPatterns.Project2
{
    public class EtchedBorder : Border
    {
        public EtchedBorder(Container container) : base(container){

        }
        public override void generateBorder(){

            getContainer().doLayout();
            getContainer().dispose();
            Console.WriteLine("etched border\n");
        }

    }
}