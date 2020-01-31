using System;

namespace DesignPatterns.Project2
{
    public class BorderSolid : Border
    {
        public BorderSolid(Container container) : base(container){

        }

        public override void generateBorder()
        {
            getContainer().doLayout();
            getContainer().dispose();
            Console.WriteLine("solid border\n");
        }
    }
}