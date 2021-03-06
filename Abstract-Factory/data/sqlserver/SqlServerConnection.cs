using System;

namespace Design_Patterns.data.sqlserver
{
    //concrete product
    public class SqlServerConnection : DbConnection
    {
        public override void close()
        {
            Console.WriteLine("close sqlserver connection");
        }

        public override void open()
        {
            Console.WriteLine("open sqlserver connection");
        }
    }
}