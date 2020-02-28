using System;

namespace Design_Patterns.data.sqlserver
{
    //concrete product
    public class SqlServerCommands : DbCommands
    {
        public override bool delete()
        {
            Console.WriteLine("delete on sqlserve.");
            return true;
        }

        public override bool save()
        {
            Console.WriteLine("save on sqlserve.");
            return true;
        }

        public override bool update()
        {
            Console.WriteLine("update on sqlserve.");
            return true;
        }
    }
}